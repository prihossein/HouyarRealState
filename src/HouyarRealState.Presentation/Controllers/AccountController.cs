using FluentValidation;
using HouyarRealState.Application.DTOs.Identity;
using HouyarRealState.Application.Queries;
using HouyarRealState.Application.Services;
using HouyarRealState.Domain.Entities.User;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HouyarRealState.Presentation.Controllers
{
    public class AccountController : Controller
    {

        private readonly ILanguageService _languageService;
        private readonly IMediator _mediator;
        public readonly UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;

        public AccountController(ILanguageService languageService, IMediator mediator, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _languageService = languageService;
            _mediator = mediator;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Route("/Login")]
        public async Task<IActionResult> Login(string returnUrl = "/")
        {

            if (User.Identity?.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.RandomBackground = $"{NameGenerator.GenerateRandomNumber(1, 60).ToString("00")}.gif";
            ViewBag.ReturnUrl = returnUrl;


            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Login(GetTokenDTO dto, string returnUrl = "/")
        {



            try
            {
                var result = await _mediator.Send(new GetTokenQuery(dto));

                await _mediator.Send(new SignInQuery(result.Value));

                return Json(new { status = true, message = "ورود کاربر با موفقیت انجام شد", returnUrl = returnUrl });

            }
            catch (ValidationException fluentEx)
            {

                var message = fluentEx.Errors.Select(x => x.ErrorMessage).FirstOrDefault();

                if (string.IsNullOrWhiteSpace(message))
                {
                    message = fluentEx.Message;
                }

                return Json(new { status = false, message = message });

            }


        }


        [Route("/Logout")]
        public async Task<IActionResult> Logout()
        {
            // حذف Cookie Authorization
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }


    }
}
