using HouyarRealState.Application.Services;
using HouyarRealState.Domain.Entities.Properties;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class PropertyStatusRepository: IPropertyStatusRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICacheManagerService _cacheManagerService;

        public PropertyStatusRepository(ApplicationDbContext context, IMapper mapper, ICacheManagerService cacheManagerService)
        {
            _context = context;
            _mapper = mapper;
            _cacheManagerService = cacheManagerService;
        }

        public async Task <List<PropertyStatus>> GetPropertyStatusesAsync()
        {
            return await _context.PropertyStatuses.OrderBy(x => x.Title).ToListAsync();
        }

        public async Task<List<SelectListItem>> GetPropertyStatusesForFilterSelectList()
        {

            List<SelectListItem> lstSelectList = new List<SelectListItem>();

            var propertyStatuses = _context.PropertyStatuses.OrderBy(x => x.Title);

            lstSelectList.Add(new SelectListItem
            {
                Text = "انتخاب وضعیت",
                Value = "",
                Disabled = true
            });

            foreach (var propertyStatus in propertyStatuses)
            {
                lstSelectList.Add(new SelectListItem
                {
                    Text = propertyStatus.Title,
                    Value = propertyStatus.Id.ToString()
                });

            }

            return lstSelectList;
        }
    }
}
