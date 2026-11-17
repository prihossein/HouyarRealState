using HouyarRealState.Application.Queries;
using HouyarRealState.Application.Wrappers;
using HouyarRealState.Domain.Entities.User;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HouyarRealState.Infrastructure.Handlers.UserHandlers
{
    internal class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, Result<ApplicationUser?>>
    {

        public readonly UserManager<ApplicationUser> _userManager;

        public GetUserByIdQueryHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Result<ApplicationUser?>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.id.ToString());
            return new Result<ApplicationUser?> { Value = user };
        }
    }
}
