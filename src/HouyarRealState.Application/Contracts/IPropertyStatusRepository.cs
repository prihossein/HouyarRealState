using HouyarRealState.Domain.Entities.Properties;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Application.Contracts
{
    public interface IPropertyStatusRepository
    {

        Task<List<SelectListItem>> GetPropertyStatusesForFilterSelectList();
        Task<List<PropertyStatus>> GetPropertyStatusesAsync();
    }
}
