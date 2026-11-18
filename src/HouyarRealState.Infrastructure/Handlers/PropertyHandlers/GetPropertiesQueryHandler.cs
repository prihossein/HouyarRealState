using HouyarRealState.Application.DTOs;
using HouyarRealState.Application.DTOs.Properties;
using HouyarRealState.Application.Helpers;
using HouyarRealState.Application.Queries;
using HouyarRealState.Application.Wrappers;
using MediatR;

namespace HouyarRealState.Infrastructure.Handlers.PropertyHandlers
{
    public class GetPropertiesQueryHandler : IRequestHandler<GetPropertiesQuery, Result<Tuple<List<PropertyDTO>, int>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public GetPropertiesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        public async Task<Result<Tuple<List<PropertyDTO>, int>>> Handle(GetPropertiesQuery request, CancellationToken cancellationToken)
        {
            var properties = await _unitOfWork.PropertyRepository.GetAllAsync();

            #region Filters
            if (!string.IsNullOrWhiteSpace(request.filterTilte))
            {
                properties = properties.Where(x => x.Title.Contains(request.filterTilte)).ToList();
            }

            if (request.filterPropertyTypeId != null)
            {
                properties = properties.Where(x => x.PropertyTypeId == request.filterPropertyTypeId.Value).ToList();
            }

            if (request.filterPropertyRequestId != null)
            {
                properties = properties.Where(x => x.PropertyRequestTypeId == request.filterPropertyRequestId.Value).ToList();
            }


            if (request.filterTransactionTypeId != null)
            {
                properties = properties.Where(x => x.TransactionTypeId == request.filterTransactionTypeId.Value).ToList();
            }

            if (request.startCreateDate != null)
            {
                properties = properties.Where(x => x.CreateDate.Date >= request.startCreateDate.ToMiladi()).ToList();
            }

            if (request.endCreateDate != null)
            {
                properties = properties.Where(x => x.CreateDate.Date <= request.endCreateDate.ToMiladi()).ToList();
            }
            #endregion

            return new Result<Tuple<List<PropertyDTO>, int>>
            {
                Value = PageList<PropertyDTO>.CreatePagedList(_mapper.Map<List<PropertyDTO>>(properties), request.pageId, 50)
            };
        }
    }
}
