

using HouyarRealState.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouyarRealState.Presentation.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = $"{UserRoleNames.Owner}, {UserRoleNames.Administrator}")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
