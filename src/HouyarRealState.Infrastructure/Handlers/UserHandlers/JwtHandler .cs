using System.Net.Http.Headers;
using HouyarRealState.Application.Services;

namespace HouyarRealState.Infrastructure.Handlers.UserHandlers
{
    public class JwtHandler : DelegatingHandler
    {
        private readonly ITokenService _tokenService;

        public JwtHandler(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var token = _tokenService.GetToken();

            if (!string.IsNullOrWhiteSpace(token))
            {
                request.Headers.Authorization =
                    new AuthenticationHeaderValue(
                        "Bearer",
                        token);
            }

            return await base.SendAsync(
                request,
                cancellationToken);
        }
    }
}
