using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using AutoMapper;
using HouyarRealState.Application.Contracts;
using HouyarRealState.Application.DTOs.Settings;
using HouyarRealState.Domain.Entities.Settings;
using HouyarRealState.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class LanguageRepository : GenericRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(ApplicationDbContext context,IMapper mapper) : base(context,mapper)
        {
        }

        public async Task CreateAsync(LanguageDTO dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            var entity = _mapper.Map<Language>(dto);

            await AddAsync(entity);
        }

        public async Task<List<LanguageDTO>?> GetAllLanguagesAsync()
        {
            var languages = await GetAllAsync();

            return _mapper.Map<List<LanguageDTO>>(languages);
        }

        public async Task<LanguageDTO?> GetLanguageByIdAsync(Guid id)
        {
            var language = await GetByIdAsync(id);

            return language is null
                ? null
                : _mapper.Map<LanguageDTO>(language);
        }

        public async Task UpdateAsync(Guid id, LanguageDTO dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            var language = await GetByIdAsync(id);

            if (language is null)
            {
                throw new KeyNotFoundException(
                    $"Language with ID '{id}' was not found.");
            }

            _mapper.Map(dto, language);

            Update(language);
        }

        public async Task DeleteAsync(Guid id)
        {
            var language = await GetByIdAsync(id);

            if (language is null)
            {
                throw new KeyNotFoundException(
                    $"Language with ID '{id}' was not found.");
            }

            Delete(language);
        }

        public async Task<List<LanguageDTO>?> Where(Expression<Func<Language, bool>> predicate,CancellationToken cancellationToken = default)
        {
            var languages = await _context.Languages
                .Where(predicate)
                .ToListAsync(cancellationToken);

            return _mapper.Map<List<LanguageDTO>>(languages);
        }

        public async Task<bool> ExistByIdAsync(Guid id)
        {
            return await _context.Languages.AnyAsync(x => x.Id == id);
        }
    }
}
