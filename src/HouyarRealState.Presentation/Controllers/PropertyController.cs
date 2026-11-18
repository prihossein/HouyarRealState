using HouyarRealState.Infrastructure.Identity;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouyarRealState.Presentation.Controllers
{

    [Authorize(Roles = $"{UserRoleNames.Owner}, {UserRoleNames.Administrator}")]
    public class PropertyController : Controller
    {
        private readonly IMediator _mediator;
        public PropertyController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [Route("/Properties")]
        public IActionResult Properties()
        {
            return View();
        }
    }
}
