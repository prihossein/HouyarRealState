using System.Diagnostics;
using HouyarRealState.Application.Services;
using HouyarRealState.Infrastructure.Identity;
using HouyarRealState.Presentation.Models;
using Microsoft.AspNetCore.Authorization;
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


        [Authorize(Roles = $"{UserRoleNames.Owner}, {UserRoleNames.Administrator}")]
        public async Task<IActionResult> Index()
        {

            return View();
        }

        public IActionResult Privacy(string languageCulture = LanguageCultures.Persian)
        {
            return View();
        }


        #region GetRandomWordsOfElders
        public IActionResult GetRandomWordsOfElders()
        {
            return Json(new
            {
                status = true,
                randomWordsOfElders = WordsOfEldersTools.GetRandomWordsOfElders()
            });
        }
        #endregion


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string languageCulture = LanguageCultures.Persian)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
