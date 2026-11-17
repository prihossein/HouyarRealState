using HouyarRealState.Application.Services;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        #region Repositories

        #endregion

        private readonly ICacheManagerService _cacheManagerService;
        public UnitOfWork(ApplicationDbContext context, IMapper mapper, ICacheManagerService cacheManagerService)
        {
            _context = context;
            _mapper = mapper;
            _cacheManagerService = cacheManagerService;

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
