using HouyarRealState.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace HouyarRealState.Presentation.Controllers
{
    public class AccountController : Controller
    {

        private readonly ILanguageService _languageService;

        public AccountController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [Route("/Login")]
        public async Task<IActionResult> Login(string? languageCulture,string returnUrl = "/")
        {

            if (User.Identity?.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Dashboard");
            }




            if (!string.IsNullOrWhiteSpace(languageCulture))
            {
                if (languageCulture.ToLower() == LanguageCultures.Persian.ToLower() || languageCulture.ToLower() == LanguageCultures.English.ToLower() || languageCulture.ToLower() == LanguageCultures.Arabic.ToLower() || languageCulture.ToLower() == LanguageCultures.Turkish.ToLower())
                {
                    ViewData["LanguageCulture"] = await _languageService.ChangeLanguageAsync(languageCulture, HttpContext);
                }

            }
            else
            {
                ViewData["LanguageCulture"] = await _languageService.GetLanguageCultureAsync(HttpContext);
            }



            if ((string)ViewData["LanguageCulture"] != LanguageCultures.Persian)
            {
                ViewData["ChangeUrl"] = $"/Login?languageCulture={ViewData["LanguageCulture"]}";
            }


            ViewBag.ReturnUrl = returnUrl;


            return View();
        }
    }
}
