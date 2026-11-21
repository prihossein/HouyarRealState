using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Application.Contracts
{
    public interface IAccountRepository
    {
        Task<List<SelectListItem>> GetAgentsForFilterSelectList();
    }
}
