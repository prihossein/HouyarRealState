using HouyarRealState.Application.Wrappers;
using HouyarRealState.Domain.Entities.User;
using Microsoft.AspNetCore.Identity;

namespace HouyarRealState.Application.DTOs.User
{
    public class UserManagerDTO
    {
        public ApplicationUser User { get; set; }


        public List<IdentityRole> IdentityRoles { get; set; } = new List<IdentityRole>();

        public List<string> Roles { get; set; } = new List<string>();
    }
}
