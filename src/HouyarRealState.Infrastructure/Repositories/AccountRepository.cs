using System.Data;
using HouyarRealState.Application.DTOs;
using HouyarRealState.Application.DTOs.User;
using HouyarRealState.Application.Helpers;
using HouyarRealState.Application.Services;
using HouyarRealState.Application.Wrappers;
using HouyarRealState.Domain.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class AccountRepository: IAccountRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICacheManagerService _cacheManagerService;
        public readonly UserManager<ApplicationUser> _userManager;

        public AccountRepository(ApplicationDbContext context, IMapper mapper, ICacheManagerService cacheManagerService, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _cacheManagerService = cacheManagerService;
            _userManager = userManager;
    
        }



        public async Task<IdentityResult> AddUserAsync(AddUserDTO model)
        {
            string userName = model.Mobile;

            var code = NameGenerator.GeneratePassword(6, "0123456789ABCDEFHIJKLMNOPQRSTUBWXYZ");

            var existCode = await AnyUserAsync(u => u.Code == code);

            while (existCode)
            {
                code = NameGenerator.GeneratePassword(6, "0123456789ABCDEFHIJKLMNOPQRSTUBWXYZ");
                existCode = await AnyUserAsync(u => u.Code == code);
            }

            var user = new ApplicationUser
            {
                Code = code,
                Email = model.Email,
                Mobile = model.Mobile,
                RegisterDate = DateTime.Now,
                UserName = userName,
                OTPCode = "00000",
                OTPCodeExpireDateTime = DateTime.Now
            };

            var identityResult = await _userManager.CreateAsync(user, model.ConfirmPassword);

            if (identityResult.Succeeded)
            {
                if (model.Role.Count() > 0)
                {
                    await _userManager.AddToRolesAsync(user, model.Role);
                }

            }

            return identityResult;

        }




        public async Task<bool> AnyUserAsync(Expression<Func<ApplicationUser, bool>> predicate)
        {
            return await _userManager.Users.AnyAsync(predicate);
        }

        public async Task<Tuple<List<UserManagerDTO>, int>> GetUserManagerAsync(int pageId = 1, string userName = "", string code = "", string mobileNumber = "", string fullName = "", string? role = null, int take = 100)
        {
            var users = _userManager.Users.OrderByDescending(x => x.RegisterDate);

            List<UserManagerDTO> userManagerDTO = new List<UserManagerDTO>();

            #region Filter Users
            if (!string.IsNullOrWhiteSpace(code))
            {
                users = users.Where(x => x.Code.ToLower() == code.ToLower())
                      .OrderByDescending(x => x.RegisterDate);
            }


            if (!string.IsNullOrWhiteSpace(userName))
            {
                users = users.Where(x => x.UserName.ToLower().Contains(userName.Trim().ToLower()))
                      .OrderByDescending(x => x.RegisterDate);
            }

            if (!string.IsNullOrWhiteSpace(mobileNumber))
            {
                users = users.Where(x => x.Mobile == mobileNumber.Trim())
                      .OrderByDescending(x => x.RegisterDate);
            }

            if (!string.IsNullOrWhiteSpace(fullName))
            {
                users = users.Where(x => x.FullName.ToLower().Contains(fullName.Trim().ToLower()))
                      .OrderByDescending(x => x.RegisterDate);
            }



            if (users != null && await users.CountAsync() > 0)
            {
                foreach (var user in users)
                {

                    List<string> enumRoles = new List<string>();
                    var roles = await _userManager.GetRolesAsync(user);

                    if (roles != null && roles.Count() > 0)
                    {
                        foreach (var userRole in roles)
                        {
                            switch (userRole)
                            {
                                case UserRoleNames.Owner:
                                    enumRoles.Add("برنامه نویس");
                                    break;

                                case UserRoleNames.Administrator:
                                    enumRoles.Add("مدیر");
                                    break;

                                case UserRoleNames.Agent:
                                    enumRoles.Add("مشاور");
                                    break;

                                case UserRoleNames.User:
                                    enumRoles.Add("کاربر");
                                    break;

                                default:
                                    enumRoles.Add("تعریف نشده");
                                    break;
                            }
                        }
                    }

                    userManagerDTO.Add(new UserManagerDTO
                    {
                        User = user,
                        Roles = enumRoles
                    });
                }
            }




            #endregion

            return PageList<UserManagerDTO>.CreatePagedList(userManagerDTO, pageId, take);

        }





        public async Task<List<SelectListItem>> GetAgentsForFilterSelectList()
        {

            List<SelectListItem> lstSelectList = new List<SelectListItem>();

            var users = _context.Users.OrderBy(p => p.RegisterDate);

            lstSelectList.Add(new SelectListItem
            {
                Text = "انتخاب مشاور",
                Value = "",
                Disabled = true
            });

            foreach (var user in users)
            {

                if (await _userManager.IsInRoleAsync(user, UserRoleNames.Owner) || await _userManager.IsInRoleAsync(user, UserRoleNames.Administrator) || await _userManager.IsInRoleAsync(user, UserRoleNames.Agent))
                {

                   lstSelectList.Add(new SelectListItem
                    {
                        Text = $"{user.UserName} - {user.FullName}",
                        Value = user.Id.ToString()
                    });
                }

            }

            return lstSelectList;
        }
    }
}
