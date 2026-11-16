using HouyarRealState.Application.Services;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        #region Repositories
        public ILanguageRepository LanguageRepository { get; private set; }
        public IFooterRepository FooterRepository { get; private set; }
        #endregion

        private readonly ICacheManagerService _cacheManagerService;
        public UnitOfWork(ApplicationDbContext context, IMapper mapper, ICacheManagerService cacheManagerService, ILanguageRepository languageRepository)
        {
            _context = context;
            _mapper = mapper;
            _cacheManagerService = cacheManagerService;
            LanguageRepository = new LanguageRepository(context, mapper);
            FooterRepository = new FooterRepository(context, mapper);
        }

        public async Task ComplateAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new FluentValidation.ValidationException("خطای ذخیره اطلاعات! با مدیر سایت تماس بگیرید", new List<FluentValidation.Results.ValidationFailure>());
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
