using System.Security.Claims;
using HouyarRealState.Application.DTOs;
using HouyarRealState.Application.Queries;
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
        private readonly IUnitOfWork _unitOfWork;

        public PropertyController(IMediator mediator, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
        }


        [Route("/Properties")]
        public async Task<IActionResult> Properties(int pageId = 1, Guid? filterPropertyTypeId = null, Guid? filterPropertyRequestId = null, Guid? filterTransactionTypeId = null, string? filterTilte = null, string? startCreateDate = null, string? endCreateDate = null)
        {
            ViewBag.CurrentPage = pageId;
            ViewBag.FilterPropertyTypeId = filterPropertyTypeId;
            ViewBag.FilterPropertyRequestId = filterPropertyRequestId;
            ViewBag.FilterTransactionTypeId = filterTransactionTypeId;
            ViewBag.FilterTilte = filterTilte;

            //var model = await _mediator.Send(new GetPropertiesQuery(pageId, filterPropertyTypeId, filterPropertyRequestId, filterTransactionTypeId, filterTilte, startCreateDate, endCreateDate));
            var model =await _unitOfWork.PropertyRepository.GetPropertiesForDashboard(pageId, filterPropertyTypeId, filterPropertyRequestId, filterTransactionTypeId, filterTilte, startCreateDate, endCreateDate);

            if (model.Properties.Item2 > 1)
            {
                PagingViewModel pagingModel = new PagingViewModel();
                {

                    pagingModel.RoundPageCount = model.Properties.Item2;
                    pagingModel.CurrentPage = pageId;
                    pagingModel.Url = "/Properties";

                    if (!string.IsNullOrWhiteSpace(filterTilte))
                    {
                        pagingModel.Filters.Add(new PagingFilterViewModel
                        {
                            Parameter = "filterTilte",
                            Value = filterTilte
                        });
                    }

                    if (filterPropertyTypeId != null)
                    {
                        pagingModel.Filters.Add(new PagingFilterViewModel
                        {
                            Parameter = "filterPropertyTypeId",
                            Value = filterPropertyTypeId.Value.ToString()
                        });
                    }

                    if (filterPropertyRequestId != null)
                    {
                        pagingModel.Filters.Add(new PagingFilterViewModel
                        {
                            Parameter = "filterPropertyRequestId",
                            Value = filterPropertyRequestId.Value.ToString()
                        });
                    }

                    if (filterTransactionTypeId != null)
                    {
                        pagingModel.Filters.Add(new PagingFilterViewModel
                        {
                            Parameter = "filterTransactionTypeId",
                            Value = filterTransactionTypeId.Value.ToString()
                        });
                    }

                }

                ViewBag.Paging = pagingModel;
            }

            return View(model);
        }


        [Route("/Property/AddProperty"),HttpGet]
        public async Task<IActionResult> AddProperty()
        {
            return View();
        }
    }
}
