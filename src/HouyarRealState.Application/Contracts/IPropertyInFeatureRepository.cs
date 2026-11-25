using System.Linq.Expressions;
using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Application.Contracts
{
    public interface IPropertyInFeatureRepository
    {
        Task<bool> AnyAsync(Expression<Func<PropertyInFeature, bool>> predicate);
    }
}
