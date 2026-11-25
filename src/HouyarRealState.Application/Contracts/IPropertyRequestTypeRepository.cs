using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Application.Contracts
{
    public interface IPropertyRequestTypeRepository
    {
        Task<List<SelectListItem>> GetPropertyRequestTypesForFilterSelectList();
    }
}
