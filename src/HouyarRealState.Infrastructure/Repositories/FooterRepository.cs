

namespace HouyarRealState.Infrastructure.Repositories
{
    public class FooterRepository : GenericRepository<Footer>, IFooterRepository
    {
        public FooterRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task CreateAsync(FooterDTO dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            var entity = _mapper.Map<Footer>(dto);

            await AddAsync(entity);
        }

        public async Task<List<FooterDTO>?> GetAllFootersAsync()
        {
            var footers = await GetAllAsync();

            return _mapper.Map<List<FooterDTO>>(footers);
        }

        public async Task<FooterDTO?> GetFooterByIdAsync(Guid id)
        {
            var footer = await GetByIdAsync(id);

            return footer is null
                ? null
                : _mapper.Map<FooterDTO>(footer);
        }

        public async Task UpdateAsync(Guid id, FooterDTO dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            var footer = await GetByIdAsync(id);

            if (footer is null)
            {
                throw new KeyNotFoundException(
                    $"Footer with ID '{id}' was not found.");
            }

            _mapper.Map(dto, footer);

            Update(footer);
        }

        public async Task DeleteAsync(Guid id)
        {
            var footer = await GetByIdAsync(id);

            if (footer is null)
            {
                throw new KeyNotFoundException(
                    $"Footer with ID '{id}' was not found.");
            }

            Delete(footer);
        }

        public async Task<List<FooterDTO>?> Where(
            Expression<Func<Footer, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(predicate);

            var footers = await _context.Footers
                .Where(predicate).ToListAsync(cancellationToken);


            return _mapper.Map<List<FooterDTO>>(footers);
        }

        public async Task<bool> ExistByIdAsync(Guid id)
        {
            return await _context.Footers
                .AnyAsync(x => x.Id == id);
        }


    }
}
