using System.Linq.Expressions;
using HouyarRealState.Application.DTOs.Settings;
using HouyarRealState.Domain.Entities.Settings;

namespace HouyarRealState.Application.Contracts
{
    public interface ILanguageRepository : IGenericRepository<Language>
    {

        Task<List<LanguageDTO>?> Where(Expression<Func<Language, bool>> predicate, CancellationToken cancellationToken = default);
        Task CreateAsync(LanguageDTO dto);

        Task DeleteAsync(Guid id);

        Task<bool> ExistByIdAsync(Guid Id);

        Task<LanguageDTO?> GetLanguageByIdAsync(Guid Id);

        Task UpdateAsync(Guid id, LanguageDTO dto);

        Task<List<LanguageDTO>?> GetAllLanguagesAsync();
    }
}
