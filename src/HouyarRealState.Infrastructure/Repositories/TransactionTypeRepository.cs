using System;
using System.Collections.Generic;
using System.Text;
using HouyarRealState.Application.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class TransactionTypeRepository: ITransactionTypeRepository
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICacheManagerService _cacheManagerService;

        public TransactionTypeRepository(ApplicationDbContext context, IMapper mapper, ICacheManagerService cacheManagerService)
        {
            _context = context;
            _mapper = mapper;
            _cacheManagerService = cacheManagerService;
        }

        public async Task<List<SelectListItem>> GetTransactionTypesForFilterSelectList()
        {

            List<SelectListItem> lstSelectList = new List<SelectListItem>();

            var propertyTypes = _context.TransactionTypes.OrderBy(x => x.Title);

            lstSelectList.Add(new SelectListItem
            {
                Text = "انتخاب نوع ملک",
                Value = "",
                Disabled = true
            });

            foreach (var propertyType in propertyTypes)
            {
                lstSelectList.Add(new SelectListItem
                {
                    Text = propertyType.Title,
                    Value = propertyType.Id.ToString()
                });

            }

            return lstSelectList;
        }
    }
}
