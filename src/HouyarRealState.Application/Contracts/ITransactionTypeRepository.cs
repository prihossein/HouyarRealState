using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Application.Contracts
{
    public interface ITransactionTypeRepository
    {
        Task<List<SelectListItem>> GetTransactionTypesForFilterSelectList();
    }
}
