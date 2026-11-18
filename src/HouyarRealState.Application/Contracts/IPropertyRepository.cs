using System.Linq.Expressions;
using HouyarRealState.Application.DTOs.Properties;
using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Application.Contracts
{
    public interface IPropertyRepository : IGenericRepository<Property>
    {
        Task<int> CountPropertiesAsync(Expression<Func<Property, bool>> predicate);
        Task CreateAsync(PropertyDTO dto);

        Task DeleteAsync(Guid id);

        Task<PropertyDTO?> FirstOrDefaultAsync(Expression<Func<Property, bool>> predicate);

        Task UpdateAsync(Guid id, PropertyDTO dto);

        Task<List<PropertyDTO>?> GetAllPropertiesAsync();
    }
}
