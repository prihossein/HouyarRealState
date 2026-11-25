using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Application.Contracts
{
    public interface IPropertyTypeRepository
    {
        Task<List<SelectListItem>> GetPropertyTypesForFilterSelectList();
    }
}
