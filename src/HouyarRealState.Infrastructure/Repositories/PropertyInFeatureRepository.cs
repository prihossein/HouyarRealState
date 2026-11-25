using System;
using System.Collections.Generic;
using System.Text;
using HouyarRealState.Application.Services;
using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class PropertyInFeatureRepository: IPropertyInFeatureRepository
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICacheManagerService _cacheManagerService;


        public PropertyInFeatureRepository(ApplicationDbContext context, IMapper mapper, ICacheManagerService cacheManagerService)
        {
            _context = context;
            _mapper = mapper;
            _cacheManagerService = cacheManagerService;
        }

        public async Task<bool> AnyAsync(Expression<Func<PropertyInFeature, bool>> predicate)
        {
            return await _context.PropertyInFeatures.AnyAsync(predicate);
        }


    }
}
