using HouyarRealState.Application.DTOs.Identity;
using HouyarRealState.Application.Queries;
using HouyarRealState.Application.Wrappers;
using HouyarRealState.Infrastructure.Identity;

using MediatR;

namespace HouyarRealState.Infrastructure.Handlers.UserHandlers
{
    public class GetTokenQueryHandler : IRequestHandler<GetTokenQuery, Result<JwtResultDTO?>>
    {
        private readonly JwtTokenService _jwtTokenService;

        public GetTokenQueryHandler(JwtTokenService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
        }


        public async Task<Result<JwtResultDTO?>> Handle(GetTokenQuery request, CancellationToken cancellationToken)
        {
            var jwtToken = await _jwtTokenService.GenerateTokenAsync(request.dto);
            return new Result<JwtResultDTO?> { Value = jwtToken };
        }
    }
}
