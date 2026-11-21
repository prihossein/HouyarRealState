using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Application.Contracts
{
    public interface IPropertyFeatureRepository
    {
        Task<List<PropertyFeature>> GetPropertyFeaturesAsync();
    }
}
