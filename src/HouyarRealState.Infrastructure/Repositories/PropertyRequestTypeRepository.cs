using HouyarRealState.Application.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class PropertyRequestTypeRepository: IPropertyRequestTypeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICacheManagerService _cacheManagerService;

        public PropertyRequestTypeRepository(ApplicationDbContext context, IMapper mapper, ICacheManagerService cacheManagerService)
        {
            _context = context;
            _mapper = mapper;
            _cacheManagerService = cacheManagerService;
        }

        public async Task<List<SelectListItem>> GetPropertyRequestTypesForFilterSelectList()
        {

            List<SelectListItem> lstSelectList = new List<SelectListItem>();

            var propertyRequestTypes = _context.PropertyRequestTypes.OrderBy(x => x.Title);

            lstSelectList.Add(new SelectListItem
            {
                Text = "انتخاب نوع درخواست",
                Value = "",
                Disabled = true
            });

            foreach (var propertyRequestType in propertyRequestTypes)
            {
                lstSelectList.Add(new SelectListItem
                {
                    Text = propertyRequestType.Title,
                    Value = propertyRequestType.Id.ToString()
                });

            }

            return lstSelectList;
        }
    }
}
