

using HouyarRealState.Application.DTOs.Identity;

namespace HouyarRealState.Application.Services
{

    public interface ITokenService
    {
        Task<bool> LoginAsync(GetTokenDTO dto);

        string? GetToken();

        void Logout();
    }
}
