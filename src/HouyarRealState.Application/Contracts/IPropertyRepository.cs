using System.Linq.Expressions;
using HouyarRealState.Application.DTOs.Properties;
using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Application.Contracts
{
    public interface IPropertyRepository : IGenericRepository<Property>
    {
        Task<PropertyForDashboardDTO> GetPropertiesForDashboard(int pageId = 1, Guid? filterPropertyTypeId = null, Guid? filterPropertyRequestId = null, Guid? filterTransactionTypeId = null, string? filterTilte = null, string? startCreateDate = null, string? endCreateDate = null);
        Task<int> CountPropertiesAsync(Expression<Func<Property, bool>> predicate);
        Task CreateAsync(PropertyDTO dto);

        Task DeleteAsync(Guid id);

        Task<PropertyDTO?> FirstOrDefaultAsync(Expression<Func<Property, bool>> predicate);

        Task UpdateAsync(Guid id, PropertyDTO dto);

        Task<List<PropertyDTO>?> GetAllPropertiesAsync();
    }
}
