using HouyarRealState.Application.DTOs.Properties;
using HouyarRealState.Application.Wrappers;
using MediatR;

namespace HouyarRealState.Application.Commands
{
    public record CreatePropertyCommand(AddPropertyDTO dto) : IRequest<Result>;
}
