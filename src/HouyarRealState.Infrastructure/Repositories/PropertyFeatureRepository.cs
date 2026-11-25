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


        public async Task AddAsync(PropertyFeature model)
        {
            await _context.PropertyFeatures.AddAsync(model);
            _context.SaveChanges();
        }

        public async Task<List<PropertyFeature>> GetPropertyFeaturesAsync(Guid propertyId)
        {
            return await _context.PropertyInFeatures
                .Where(x => x.PropertyId == propertyId)
                .Include(x => x.PropertyFeature)
                .Select(x => new PropertyFeature
                {
                    Title = x.PropertyFeature.Title,
                    Id = x.PropertyFeature.Id
                }).ToListAsync();
        }

        public async Task<List<PropertyFeature>> GetPropertyFeaturesAsync()
        {
            return await _context.PropertyFeatures.OrderBy(x => x.Title).ToListAsync();
        }
    }
}
