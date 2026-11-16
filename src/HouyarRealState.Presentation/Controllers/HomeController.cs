using System.Diagnostics;
using HouyarRealState.Application.Services;
using HouyarRealState.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace HouyarRealState.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILanguageService _languageService;
        public HomeController(ILanguageService languageService)
        {
            _languageService = languageService;
        }


        [Route("/{languageCulture?}")]
        public async Task<IActionResult> Index(string? languageCulture)
        {



            if (!string.IsNullOrWhiteSpace(languageCulture)) 
            {
                if (languageCulture.ToLower() == LanguageCultures.Persian.ToLower() || languageCulture.ToLower() == LanguageCultures.English.ToLower() || languageCulture.ToLower() == LanguageCultures.Arabic.ToLower() || languageCulture.ToLower() == LanguageCultures.Turkish.ToLower()) 
                {
                    ViewData["LanguageCulture"] =  await _languageService.ChangeLanguageAsync(languageCulture, HttpContext);
                }

            }
            else
            {
                ViewData["LanguageCulture"] = await _languageService.GetLanguageCultureAsync(HttpContext);
            }

            

            if ((string)ViewData["LanguageCulture"] != LanguageCultures.Persian)
            {
                ViewData["ChangeUrl"] = $"/{ViewData["LanguageCulture"]}";
            }

            return View();
        }

        public IActionResult Privacy(string languageCulture = LanguageCultures.Persian)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string languageCulture = LanguageCultures.Persian)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
