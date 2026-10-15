

using System.Net.Http.Json;
using HouyarRealState.Application.DTOs.Identity;
using HouyarRealState.Application.Services;

namespace HouyarRealState.Infrastructure.Services
{
    public class TokenService : ITokenService
    {
        private readonly HttpClient _httpClient;

        private string? _token;

        public TokenService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> LoginAsync(GetTokenDTO dto)
        {


            using var request = new HttpRequestMessage(HttpMethod.Post, $"api/GetToken");

            request.Headers.Add("x-version", "1.0");

            request.Content = JsonContent.Create(dto);

            using var response =
                await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                return false;

            var result =
                await response.Content
                    .ReadFromJsonAsync<JwtResultDTO>();

            if (result == null ||
                string.IsNullOrWhiteSpace(result.Token))
            {
                return false;
            }

            // ذخیره JWT
            _token = result.Token;

            return true;
        }

        public string? GetToken()
        {
            return _token;
        }

        public void Logout()
        {
            _token = null;
        }
    }
}
