using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Application.Contracts
{
    public interface IPropertyFeatureRepository
    {
        Task<List<PropertyFeature>> GetPropertyFeaturesAsync(Guid propertyId);
        Task<List<PropertyFeature>> GetPropertyFeaturesAsync();
        Task AddAsync(PropertyFeature model);
    }
}
