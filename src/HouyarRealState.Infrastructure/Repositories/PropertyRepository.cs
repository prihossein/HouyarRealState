using HouyarRealState.Application.DTOs.Common;
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


        public async Task<int> CountPropertiesAsync(Expression<Func<Property, bool>> predicate)
        {
            return await _context.Properties.CountAsync(predicate);
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
