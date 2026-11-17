using HouyarRealState.Application.DTOs.Identity;
using HouyarRealState.Application.Wrappers;
using HouyarRealState.Domain.Entities.User;
using MediatR;

namespace HouyarRealState.Application.Queries
{
    public record GetTokenQuery(GetTokenDTO dto) : IRequest<Result<JwtResultDTO>>;
    public record SignInQuery(JwtResultDTO dto) : IRequest<Result>;
    public record GetUserByIdQuery(Guid id) : IRequest<Result<ApplicationUser>>;
}
