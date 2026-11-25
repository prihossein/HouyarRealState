using HouyarRealState.Application.DTOs;
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
    }
}
