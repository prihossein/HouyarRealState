using Microsoft.AspNetCore.Mvc;

namespace HouyarRealState.Presentation.Controllers
{
    public class AccountController : Controller
    {

        [Route("/Login")]
        public IActionResult Login(string returnUrl = "/")
        {

            if (User.Identity?.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            
            ViewBag.ReturnUrl = returnUrl;


            return View();
        }
    }
}
