using HouyarRealState.Application.DTOs;
using HouyarRealState.Application.DTOs.Properties;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Presentation.Controllers
{

    [Authorize(Roles = $"{UserRoleNames.Owner}, {UserRoleNames.Administrator}, {UserRoleNames.Agent}"),]
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
        public async Task<IActionResult> Properties(int pageId = 1, Guid? filterPropertyStatusId = null, Guid? filterPropertyTypeId = null, Guid? filterPropertyRequestId = null, Guid? filterTransactionTypeId = null, string? filterTilte = null, string? filterAddress = null, string? startCreateDate = null, string? endCreateDate = null)
        {
            ViewBag.CurrentPage = pageId;
            ViewBag.FilterPropertyTypeId = filterPropertyTypeId;
            ViewBag.FilterPropertyRequestId = filterPropertyRequestId;
            ViewBag.FilterTransactionTypeId = filterTransactionTypeId;
            ViewBag.FilterPropertyStatusId = filterPropertyStatusId;
            ViewBag.FilterTilte = filterTilte;
            ViewBag.FilterAddress = filterAddress;

            var model = await _unitOfWork.PropertyRepository.GetPropertiesForDashboard(pageId, filterPropertyStatusId, filterPropertyTypeId, filterPropertyRequestId, filterTransactionTypeId, filterTilte, filterAddress, startCreateDate, endCreateDate);

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

                    if (!string.IsNullOrWhiteSpace(filterAddress))
                    {
                        pagingModel.Filters.Add(new PagingFilterViewModel
                        {
                            Parameter = "filterAddress",
                            Value = filterAddress
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


                    if (filterPropertyStatusId != null)
                    {
                        pagingModel.Filters.Add(new PagingFilterViewModel
                        {
                            Parameter = "filterPropertyStatusId",
                            Value = filterPropertyStatusId.Value.ToString()
                        });
                    }

                }

                ViewBag.Paging = pagingModel;
            }

            return View(model);
        }



        #region AddProperty
        [Route("/Property/AddProperty"), HttpGet]
        public async Task<IActionResult> AddProperty()
        {

            var agents = await _unitOfWork.AccountRepository.GetAgentsForFilterSelectList();
            ViewData["Agents"] = new SelectList(agents, "Value", "Text");

            var propertyStatuses = await _unitOfWork.PropertyStatusRepository.GetPropertyStatusesForFilterSelectList();
            ViewData["PropertyStatuses"] = new SelectList(propertyStatuses, "Value", "Text");


            var transactionTypes = await _unitOfWork.TransactionTypeRepository.GetTransactionTypesForFilterSelectList();
            ViewData["TransactionTypes"] = new SelectList(transactionTypes, "Value", "Text");

            var propertyRequestTypes = await _unitOfWork.PropertyRequestTypeRepository.GetPropertyRequestTypesForFilterSelectList();
            ViewData["PropertyRequestTypes"] = new SelectList(propertyRequestTypes, "Value", "Text");


            var propertyTypes = await _unitOfWork.PropertyTypeRepository.GetPropertyTypesForFilterSelectList();
            ViewData["PropertyTypes"] = new SelectList(propertyTypes, "Value", "Text");


            ViewBag.PropertyFeatures = await _unitOfWork.PropertyFeatureRepository.GetPropertyFeaturesAsync();

            return View();
        }


        [Route("/Property/AddProperty"), HttpPost]
        public async Task<IActionResult> AddProperty(AddPropertyDTO model)
        {



            if (model.PropertyRequestTypeId == Guid.Parse("{00000000-0000-0000-0000-000000000000}"))
            {
                return Json(new { status = false, message = "نوع درخواست را انتخاب کنید" });
            }

            if (model.PropertyTypeId == Guid.Parse("{00000000-0000-0000-0000-000000000000}"))
            {
                return Json(new { status = false, message = "نوع ملک را انتخاب کنید" });
            }

            if (model.TransactionTypeId == Guid.Parse("{00000000-0000-0000-0000-000000000000}"))
            {
                return Json(new { status = false, message = "نوع معامله را انتخاب کنید" });
            }

            if (model.AgentId == Guid.Parse("{00000000-0000-0000-0000-000000000000}"))
            {
                return Json(new { status = false, message = "مشاور را انتخاب کنید" });
            }

            if (model.PropertyStatusId == Guid.Parse("{00000000-0000-0000-0000-000000000000}"))
            {
                return Json(new { status = false, message = "وضعیت را انتخاب کنید" });
            }

            if (!ModelState.IsValid)
            {
                var error = ModelState.GetModelStateErrors();
                return Json(new { status = false, message = error });
            }


            await _unitOfWork.PropertyRepository.AddAsync(model);


            return Json(new { status = true, message = "ملک با موفقیت افزوده شد" });
        }
        #endregion


        #region UpdateProperty
        [Route("/Property/UpdateProperty/{Id}"), HttpGet]
        public async Task<IActionResult> UpdateProperty(Guid Id)
        {

            var property = await _unitOfWork.PropertyRepository.GetPropertyForUpdateAsync(Id);

            if (property == null)
            {
                return NotFound();
            }

            var agents = await _unitOfWork.AccountRepository.GetAgentsForFilterSelectList();
            ViewData["Agents"] = new SelectList(agents, "Value", "Text", property.AgentId);

            var propertyStatuses = await _unitOfWork.PropertyStatusRepository.GetPropertyStatusesForFilterSelectList();
            ViewData["PropertyStatuses"] = new SelectList(propertyStatuses, "Value", "Text");


            var transactionTypes = await _unitOfWork.TransactionTypeRepository.GetTransactionTypesForFilterSelectList();
            ViewData["TransactionTypes"] = new SelectList(transactionTypes, "Value", "Text", property.TransactionTypeId);

            var propertyRequestTypes = await _unitOfWork.PropertyRequestTypeRepository.GetPropertyRequestTypesForFilterSelectList();
            ViewData["PropertyRequestTypes"] = new SelectList(propertyRequestTypes, "Value", "Text");


            var propertyTypes = await _unitOfWork.PropertyTypeRepository.GetPropertyTypesForFilterSelectList();
            ViewData["PropertyTypes"] = new SelectList(propertyTypes, "Value", "Text", property.PropertyTypeId);


            ViewBag.PropertyFeatures = await _unitOfWork.PropertyFeatureRepository.GetPropertyFeaturesAsync();

            return View(property);
        }


        [Route("/Property/UpdateProperty"), HttpPost]
        public async Task<IActionResult> UpdateProperty(UpdatePropertyDTO model)
        {



            if (model.PropertyRequestTypeId == Guid.Parse("{00000000-0000-0000-0000-000000000000}"))
            {
                return Json(new { status = false, message = "نوع درخواست را انتخاب کنید" });
            }

            if (model.PropertyTypeId == Guid.Parse("{00000000-0000-0000-0000-000000000000}"))
            {
                return Json(new { status = false, message = "نوع ملک را انتخاب کنید" });
            }

            if (model.TransactionTypeId == Guid.Parse("{00000000-0000-0000-0000-000000000000}"))
            {
                return Json(new { status = false, message = "نوع معامله را انتخاب کنید" });
            }

            if (model.AgentId == Guid.Parse("{00000000-0000-0000-0000-000000000000}"))
            {
                return Json(new { status = false, message = "مشاور را انتخاب کنید" });
            }

            if (model.PropertyStatusId == Guid.Parse("{00000000-0000-0000-0000-000000000000}"))
            {
                return Json(new { status = false, message = "وضعیت را انتخاب کنید" });
            }

            if (!ModelState.IsValid)
            {
                var error = ModelState.GetModelStateErrors();
                return Json(new { status = false, message = error });
            }


            var isUpdated = await _unitOfWork.PropertyRepository.UpdateAsync(model);

            if (!isUpdated)
            {
                return Json(new { status = false, message = "خطا در بروزرسانی ملک" });
            }

            return Json(new { status = true, message = "ملک با موفقیت بروزرسانی شد" });
        }
        #endregion









        [Route("/Property/Delete"), HttpPost]
        public async Task<IActionResult> Delete([FromForm] Guid propertyId)
        {

            await _unitOfWork.PropertyRepository.DeleteAsync(propertyId);

            return Json(new { status = true, message = "ملک با موفقیت حذف شد" });
        }


    }
}
