using HouyarRealState.Application.Exceptions;
using HouyarRealState.Application.Queries;
using HouyarRealState.Application.Wrappers;
using HouyarRealState.Domain.Entities.User;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HouyarRealState.Infrastructure.Handlers.UserHandlers
{
    internal class SignInQueryHandler : IRequestHandler<SignInQuery, Result>
    {

        public readonly SignInManager<ApplicationUser> _signInManager;
        public readonly UserManager<ApplicationUser> _userManager;

        public SignInQueryHandler(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<Result> Handle(SignInQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == request.dto.UserId);

            if (user == null)
            {
                throw new CustomException("User not found!");
            }

            await _signInManager.SignInAsync(user, true);

           return new Result();
        }
    }
}
