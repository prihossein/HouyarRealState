using Microsoft.AspNetCore.Mvc;

namespace HouyarRealState.Presentation.Controllers
{
    public class PageController : Controller
    {

        [Route("/About")]
        public IActionResult About()
        {
            return View();
        }



        [Route("/Contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
