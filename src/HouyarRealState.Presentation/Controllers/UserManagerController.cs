using System.Text;
using HouyarRealState.Application.DTOs;
using HouyarRealState.Application.DTOs.User;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouyarRealState.Presentation.Controllers
{

    [Authorize(Roles = $"{UserRoleNames.Owner}, {UserRoleNames.Administrator}"),]
    public class UserManagerController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public UserManagerController(IMediator mediator, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> UserManager(int pageId = 1, string userName = "",string code ="", string mobileNumber = "", string fullName = "")
        {

            ViewBag.CurrentPage = pageId;
            ViewBag.UserName = userName;
            ViewBag.MobileNumber = mobileNumber;
            ViewBag.Code = code;
            ViewBag.FullName = fullName;


            var model = await _unitOfWork.AccountRepository.GetUserManagerAsync(pageId, userName, code, code, mobileNumber, fullName, 100);

            if (model.Item2 > 1)
            {
                PagingViewModel pagingModel = new PagingViewModel();
                {

                    pagingModel.RoundPageCount = model.Item2;
                    pagingModel.CurrentPage = pageId;
                    pagingModel.Url = "/UserManager";



                    if (!string.IsNullOrWhiteSpace(userName))
                    {
                        pagingModel.Filters.Add(new PagingFilterViewModel
                        {
                            Parameter = "userName",
                            Value = userName
                        });
                    }

                    if (!string.IsNullOrWhiteSpace(mobileNumber))
                    {
                        pagingModel.Filters.Add(new PagingFilterViewModel
                        {
                            Parameter = "mobileNumber",
                            Value = mobileNumber
                        });
                    }

                    if (!string.IsNullOrWhiteSpace(code))
                    {
                        pagingModel.Filters.Add(new PagingFilterViewModel
                        {
                            Parameter = "code",
                            Value = code
                        });
                    }

                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        pagingModel.Filters.Add(new PagingFilterViewModel
                        {
                            Parameter = "fullName",
                            Value = fullName
                        });
                    }


                }

                ViewBag.Paging = pagingModel;
            }

            return View(model);
        }




        #region AddUser
        [Route("/UserManager/AddUser"), HttpPost]
        public async Task<IActionResult> AddUser(AddUserDTO model)
        {

            if (!ModelState.IsValid)
            {
                var error = ModelState.GetModelStateErrors();
                return Json(new { status = false, message = error });
            }


            if (!model.Mobile.IsMobile())
            {
                return Json(new { status = false, message = "شماره موبایل را به صورت صحیح وارد کنید" });
            }

            if (await _unitOfWork.AccountRepository.AnyUserAsync(u => u.Mobile == model.Mobile))
            {
                return Json(new { status = false, message = "شماره موبایل در پایگاه داده موجود می‌باشد" });
            }

            if (!model.UserName.IsValidCharacters("abcdefghijklmnopqrstuvwxyz_.-ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"))
            {
                return Json(new { status = false, message = "نام کاربری فقط می‌توانید شامل حروف انگلیسی بزرگ و کوچک و علامت‌های _.- باشد." });
            }

            if (await _unitOfWork.AccountRepository.AnyUserAsync(u => u.UserName == model.UserName))
            {
                return Json(new { status = false, message = "نام کاربری در پایگاه داده موجود می‌باشد" });
            }

            if (!model.Email.IsEmail())
            {
                return Json(new { status = false, message = "ایمیل را به صورت صحیح وارد کنید" });
            }

            if (await _unitOfWork.AccountRepository.AnyUserAsync(u => u.Email == model.Email))
            {
                return Json(new { status = false, message = "ایمیل در پایگاه داده موجود می‌باشد" });
            }

            if (model.Role == null || model.Role.Count() == 0)
            {
                return Json(new { status = false, message = "حداقل یک نقش را برای کاربر انتخاب کنید" });
            }

            var identityResult = await _unitOfWork.AccountRepository.AddUserAsync(model);

            if (!identityResult.Succeeded)
            {
                var errors = identityResult.Errors;

                StringBuilder sbErrors = new StringBuilder();

                foreach (var error in errors)
                {
                    sbErrors.AppendLine($"{error.Code}: {error.Description}");
                }

                return Json(new { status = false, message = sbErrors.ToString() }); ;
            }

            return Json(new { status = true, message = "افزودن کاربر با موفقیت انجام شد" });
        }
        #endregion
    }
}
