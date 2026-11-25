using HouyarRealState.Application.DTOs.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Application.Contracts
{
    public interface IAccountRepository
    {

        Task<Tuple<List<UserManagerDTO>, int>> GetUserManagerAsync(int pageId = 1, string userName = "", string code = "", string mobileNumber = "", string fullName = "", string? role = null, int take = 100);
        Task<List<SelectListItem>> GetAgentsForFilterSelectList();
    }
}
