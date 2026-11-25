using HouyarRealState.Application.DTOs;
using HouyarRealState.Application.DTOs.Properties;
using HouyarRealState.Application.Helpers;
using HouyarRealState.Application.Services;
using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class PropertyRepository : GenericRepository<Property>, IPropertyRepository
    {
        private readonly IMapper _mapper;
        private readonly ICacheManagerService _cacheManagerService;

        public PropertyRepository(ApplicationDbContext context, IMapper mapper, ICacheManagerService cacheManagerService):base(context, mapper)
        {
            _mapper = mapper;
            _cacheManagerService = cacheManagerService;
        }




        public async Task<bool> UpdateAsync(UpdatePropertyDTO dto)
        {
            var property = await _context.Properties.FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (property == null) return false;

            // Map DTO to existing tracked entity
            _mapper.Map(dto, property);

            property.ModifyDate = DateTime.Now;

            // نیازی به Update نیست
            await _context.SaveChangesAsync();

            // Remove previous features
            var propertyInFeatures = await _context.PropertyInFeatures
                .Where(x => x.PropertyId == property.Id)
                .ToListAsync();

            if (propertyInFeatures.Any())
            {
                _context.PropertyInFeatures.RemoveRange(propertyInFeatures);
            }

            // Add new features
            if (dto.PropertyFeature != null && dto.PropertyFeature.Any())
            {
                foreach (var propertyFeatureId in dto.PropertyFeature)
                {
                    await _context.PropertyInFeatures.AddAsync(
                        new PropertyInFeature
                        {
                            PropertyFeatureId = propertyFeatureId,
                            PropertyId = property.Id
                        });
                }
            }

            await _context.SaveChangesAsync();

            return true;
        }



        //public async Task<bool> UpdateAsync(UpdatePropertyDTO dto)
        //{

        //    var property = await _context.Properties.FirstOrDefaultAsync(x => x.Id == dto.Id);

        //    if (property != null)
        //    {
        //        property.ModifyDate = DateTime.Now;
        //        property = _mapper.Map<Property>(dto);


        //        _context.Properties.Update(property);
        //        await _context.SaveChangesAsync();


        //        var propertyInFeatures = await _context.PropertyInFeatures.Where(x => x.PropertyId == property.Id).ToListAsync();

        //        if (propertyInFeatures != null && propertyInFeatures.Count() > 0)
        //        {
        //            _context.PropertyInFeatures.RemoveRange(propertyInFeatures);
        //            await _context.SaveChangesAsync();
        //        }


        //        if (dto.PropertyFeature != null && dto.PropertyFeature.Count() > 0)
        //        {
        //            foreach (var propertyFeatureId in dto.PropertyFeature)
        //            {
        //                await _context.PropertyInFeatures.AddAsync(new PropertyInFeature
        //                {
        //                    PropertyFeatureId = propertyFeatureId,
        //                    PropertyId = property.Id
        //                });
        //            }

        //            await _context.SaveChangesAsync();


        //        }

        //        return true;

        //    }

           
        //    return false;




        //}


        public async Task<UpdatePropertyDTO?> GetPropertyForUpdateAsync(Guid id)
        {

            var property = await _context.Properties.FirstOrDefaultAsync(x => x.Id == id);

            if (property != null)
            {
                return _mapper.Map<UpdatePropertyDTO>(property);   
            }
            return null;
        }

        public async Task AddAsync(AddPropertyDTO dto)
        {

            var newProperty = _mapper.Map<Property>(dto);

            newProperty.CreateDate = DateTime.Now;
            newProperty.ModifyDate = DateTime.Now;

            newProperty.Code = NameGenerator.GeneratePassword(5,"ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
            var existCode = await _context.Properties.AnyAsync(x => x.Code == newProperty.Code);

            while (existCode)
            {
                newProperty.Code = NameGenerator.GeneratePassword(5, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
                existCode = await _context.Properties.AnyAsync(x => x.Code == newProperty.Code);
            }

            await _context.Properties.AddAsync(newProperty);
            await _context.SaveChangesAsync();


            if (dto.PropertyFeature != null && dto.PropertyFeature.Count() > 0) 
            {
                foreach (var propertyFeatureId in dto.PropertyFeature)
                {
                    await _context.PropertyInFeatures.AddAsync(new PropertyInFeature
                    {
                        PropertyFeatureId = propertyFeatureId,
                        PropertyId = newProperty.Id
                    });
                }

                await _context.SaveChangesAsync();


            }

        }



        public async Task<int> CountPropertiesAsync(Expression<Func<Property, bool>> predicate)
        {
            return await _context.Properties.CountAsync(predicate);
        }



        public async Task<PropertyForDashboardDTO> GetPropertiesForDashboard(int pageId = 1, Guid? filterPropertyStatusId = null, Guid? filterPropertyTypeId = null, Guid? filterPropertyRequestId = null, Guid? filterTransactionTypeId = null, string? filterTilte = null, string? filterAddress = null, string? startCreateDate = null, string? endCreateDate = null)
        {
            var model = new PropertyForDashboardDTO();

            var properties =  _context.Properties.Include(x => x.PropertyType).Include(x => x.PropertyRequestType).Include(x => x.TransactionType).Include(x => x.PropertyStatus).OrderByDescending(x => x.CreateDate);

            #region Filters
            if (!string.IsNullOrWhiteSpace(filterTilte))
            {
                properties = properties.Where(x => x.Title.Contains(filterTilte)).OrderByDescending(x => x.CreateDate);
            }

            if (!string.IsNullOrWhiteSpace(filterAddress))
            {
                properties = properties.Where(x => x.Address.Contains(filterAddress)).OrderByDescending(x => x.CreateDate);
            }

            if (filterPropertyTypeId != null)
            {
                properties = properties.Where(x => x.PropertyTypeId == filterPropertyTypeId.Value).OrderByDescending(x => x.CreateDate);
            }

            if (filterPropertyRequestId != null)
            {
                properties = properties.Where(x => x.PropertyRequestTypeId == filterPropertyRequestId.Value).OrderByDescending(x => x.CreateDate);
            }


            if (filterTransactionTypeId != null)
            {
                properties = properties.Where(x => x.TransactionTypeId == filterTransactionTypeId.Value).OrderByDescending(x => x.CreateDate);
            }

            if (filterPropertyStatusId != null)
            {
                properties = properties.Where(x => x.PropertyStatusId == filterPropertyStatusId.Value).OrderByDescending(x => x.CreateDate);
            }

            if (startCreateDate != null)
            {
                properties = properties.Where(x => x.CreateDate.Date >= startCreateDate.ToMiladi()).OrderByDescending(x => x.CreateDate);
            }

            if (endCreateDate != null)
            {
                properties = properties.Where(x => x.CreateDate.Date <= endCreateDate.ToMiladi()).OrderByDescending(x => x.CreateDate);
            }
            #endregion

           

            model.Properties = PageList<Property>.CreatePagedList((await properties.ToListAsync()), pageId, 50);
            model.CountProperties = await _context.Properties.CountAsync();
            model.PropertyRequestTypes = await _context.PropertyRequestTypes.ToListAsync();
            model.PropertyTypes = await _context.PropertyTypes.ToListAsync();
            model.TransactionTypes = await _context.TransactionTypes.ToListAsync();
            model.PropertyStatuses = await _context.PropertyStatuses.ToListAsync();

            return model;
        }





        public async Task CreateAsync(PropertyDTO dto)
        {
            
            var property =  _mapper.Map<Property>(dto);
            property.ModifyDate = DateTime.Now;

            await _context.Properties.AddAsync(property);
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Properties.FirstOrDefaultAsync(x => x.Id == id);
            entity.IsDelete = true;

            _context.Properties.Update(entity);
            await _context.SaveChangesAsync();

        }

        public Task<List<PropertyDTO>?> GetAllPropertiesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<PropertyDTO?> FirstOrDefaultAsync(Expression<Func<Property, bool>> predicate)
        {
            var properties = await _context.Properties.FirstOrDefaultAsync(predicate);
            return _mapper.Map<PropertyDTO>(properties);
        }

        public async Task UpdateAsync(Guid id, PropertyDTO dto)
        {
            var result = await _context.Properties.FirstOrDefaultAsync(x => x.Id == id);
            Update(_mapper.Map(dto, result));
            _cacheManagerService.Remove("property-list");
        }
    }
}
