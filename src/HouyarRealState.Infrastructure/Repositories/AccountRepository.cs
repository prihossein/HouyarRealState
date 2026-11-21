using System;
using System.Collections.Generic;
using System.Text;
using HouyarRealState.Application.Services;
using HouyarRealState.Domain.Entities.User;
using HouyarRealState.Infrastructure.Identity;
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
