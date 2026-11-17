

using HouyarRealState.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouyarRealState.Presentation.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = $"{UserRoleNames.Owner}, {UserRoleNames.Administrator}")]
    public class DashboardController : Controller
    {

        [Route("/Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
