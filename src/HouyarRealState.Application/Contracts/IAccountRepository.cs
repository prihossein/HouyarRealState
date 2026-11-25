using System.Linq.Expressions;
using HouyarRealState.Application.DTOs.User;
using HouyarRealState.Domain.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Application.Contracts
{
    public interface IAccountRepository
    {
        Task<IdentityResult> AddUserAsync(AddUserDTO model);
        Task<bool> AnyUserAsync(Expression<Func<ApplicationUser, bool>> predicate);
        Task<Tuple<List<UserManagerDTO>, int>> GetUserManagerAsync(int pageId = 1, string userName = "", string code = "", string mobileNumber = "", string fullName = "", string? role = null, int take = 100);
        Task<List<SelectListItem>> GetAgentsForFilterSelectList();
    }
}
