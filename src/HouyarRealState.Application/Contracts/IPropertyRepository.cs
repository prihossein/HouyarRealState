using System.Linq.Expressions;
using HouyarRealState.Application.DTOs.Properties;
using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Application.Contracts
{
    public interface IPropertyRepository : IGenericRepository<Property>
    {
        Task<bool> UpdateAsync(UpdatePropertyDTO dto);
        Task AddAsync(AddPropertyDTO dto);
        Task<PropertyForDashboardDTO> GetPropertiesForDashboard(int pageId = 1,Guid? filterPropertyStatusId = null, Guid? filterPropertyTypeId = null, Guid? filterPropertyRequestId = null, Guid? filterTransactionTypeId = null, string? filterTilte = null, string? filterAddress = null, string? startCreateDate = null, string? endCreateDate = null);
        Task<int> CountPropertiesAsync(Expression<Func<Property, bool>> predicate);
        Task CreateAsync(PropertyDTO dto);
        Task<UpdatePropertyDTO?> GetPropertyForUpdateAsync(Guid id);
        Task DeleteAsync(Guid id);

        Task<PropertyDTO?> FirstOrDefaultAsync(Expression<Func<Property, bool>> predicate);

        Task UpdateAsync(Guid id, PropertyDTO dto);

        Task<List<PropertyDTO>?> GetAllPropertiesAsync();
    }
}
