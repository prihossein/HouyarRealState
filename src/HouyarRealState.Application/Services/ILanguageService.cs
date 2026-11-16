using Microsoft.AspNetCore.Http;

namespace HouyarRealState.Application.Services
{
    public interface ILanguageService
    {


        Task<string> GetLanguageCultureAsync(HttpContext httpContext);
        Task<string> ChangeLanguageAsync(string culture, HttpContext httpContext);
    }
}
