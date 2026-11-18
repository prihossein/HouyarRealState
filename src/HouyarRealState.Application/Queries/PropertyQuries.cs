using HouyarRealState.Application.DTOs.Properties;
using HouyarRealState.Application.Wrappers;
using MediatR;

namespace HouyarRealState.Application.Queries
{
    public record GetPropertiesQuery(int pageId = 1, Guid? filterPropertyTypeId = null, Guid? filterTransactionTypeId = null, string? filterTilte = null, DateTime? startCreateDate = null, DateTime? endCreateDate = null) : IRequest<Result<Tuple<List<PropertyDTO>, int>>>;
}
