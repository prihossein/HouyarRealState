using HouyarRealState.Application.DTOs;
using HouyarRealState.Application.DTOs.Common;
using HouyarRealState.Application.DTOs.Properties;
using HouyarRealState.Application.Helpers;
using HouyarRealState.Application.Queries;
using HouyarRealState.Application.Services;
using HouyarRealState.Application.Wrappers;
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


        public async Task<int> CountPropertiesAsync(Expression<Func<Property, bool>> predicate)
        {
            return await _context.Properties.CountAsync(predicate);
        }



        public async Task<PropertyForDashboardDTO> GetPropertiesForDashboard(int pageId = 1, Guid? filterPropertyTypeId = null, Guid? filterPropertyRequestId = null, Guid? filterTransactionTypeId = null, string? filterTilte = null, string? startCreateDate = null, string? endCreateDate = null)
        {
            var model = new PropertyForDashboardDTO();

            var properties =  _context.Properties.Include(x => x.PropertyType).Include(x => x.PropertyRequestType).Include(x => x.TransactionType).OrderByDescending(x => x.CreateDate);

            #region Filters
            if (!string.IsNullOrWhiteSpace(filterTilte))
            {
                properties = properties.Where(x => x.Title.Contains(filterTilte)).OrderByDescending(x => x.CreateDate);
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
