using HouyarRealState.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouyarRealState.Presentation.Controllers
{

    [Authorize(Roles = $"{UserRoleNames.Owner}, {UserRoleNames.Administrator}")]
    public class PropertyController : Controller
    {

        [Route("/Properties")]
        public IActionResult Properties()
        {
            return View();
        }
    }
}
