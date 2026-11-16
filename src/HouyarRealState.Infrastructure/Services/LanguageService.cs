using HouyarRealState.Application.Services;
using HouyarRealState.Application.Wrappers;
using Microsoft.AspNetCore.Http;

namespace HouyarRealState.Infrastructure.Services
{
    public class LanguageService: ILanguageService
    {



        public bool ExistCookies(HttpContext httpContext, string key)
        {
            try
            {
                var cookies = httpContext.Request.Cookies[key];
                if (cookies == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }



        public async Task<string> ChangeLanguageAsync(string culture, HttpContext httpContext)
        {

            if (!string.IsNullOrWhiteSpace(culture)) 
            {
                bool existCookie = ExistCookies(httpContext, "LanguageCulture");
                if (!existCookie)
                {
                    httpContext.Response.Cookies.Append("LanguageCulture", culture, new CookieOptions { Expires = DateTime.Now.AddYears(1) });
                }
                else
                {
                    httpContext.Response.Cookies.Delete("LanguageCulture");
                    httpContext.Response.Cookies.Append("LanguageCulture", culture, new CookieOptions { Expires = DateTime.Now.AddYears(1) });
                }

                return culture;
            }
            else
            {
                httpContext.Response.Cookies.Delete("LanguageCulture");
                httpContext.Response.Cookies.Append("LanguageCulture", LanguageCultures.Persian, new CookieOptions { Expires = DateTime.Now.AddYears(1) });
                return LanguageCultures.Persian;
            }


        }


        public async Task<string> GetLanguageCultureAsync(HttpContext httpContext)
        {
            bool existCookie = ExistCookies(httpContext, "LanguageCulture");
            if (!existCookie)
            {
                return LanguageCultures.Persian;
            }
            else
            {
                var language = httpContext.Request.Cookies["LanguageCulture"];

                return language;
            }
        }
    }
}
