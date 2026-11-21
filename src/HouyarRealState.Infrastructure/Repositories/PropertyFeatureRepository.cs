using System;
using System.Collections.Generic;
using System.Text;
using HouyarRealState.Application.Services;
using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class PropertyFeatureRepository: IPropertyFeatureRepository
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICacheManagerService _cacheManagerService;

        public PropertyFeatureRepository(ApplicationDbContext context,IMapper mapper, ICacheManagerService cacheManagerService)
        {
            _mapper = mapper;
            _cacheManagerService = cacheManagerService;
            _context = context;
        }

        public async Task<List<PropertyFeature>> GetPropertyFeaturesAsync()
        {
            return await _context.PropertyFeatures.OrderBy(x => x.Title).ToListAsync();
        }
    }
}
