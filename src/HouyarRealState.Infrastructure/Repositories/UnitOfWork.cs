using HouyarRealState.Application.Services;
using HouyarRealState.Domain.Entities.User;
using Microsoft.AspNetCore.Identity;

namespace HouyarRealState.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public readonly UserManager<ApplicationUser> _userManager;

        #region Repositories
        public IPropertyRepository PropertyRepository { get; private set; }
        public IAccountRepository AccountRepository { get; private set; }
        public IPropertyFeatureRepository PropertyFeatureRepository { get; private set; }
        public IPropertyStatusRepository PropertyStatusRepository { get; private set; }
        public ITransactionTypeRepository TransactionTypeRepository { get; private set; }

     
        #endregion

        private readonly ICacheManagerService _cacheManagerService;
        public UnitOfWork(ApplicationDbContext context, IMapper mapper, ICacheManagerService cacheManagerService, UserManager<ApplicationUser> userManager, IPropertyFeatureRepository propertyFeatureRepository)
        {
            _context = context;
            _mapper = mapper;
            _cacheManagerService = cacheManagerService;
            _userManager = userManager;
            PropertyRepository = new PropertyRepository(_context, _mapper, _cacheManagerService);
            AccountRepository = new AccountRepository(_context, _mapper, _cacheManagerService, _userManager);
            PropertyFeatureRepository = new PropertyFeatureRepository(_context, _mapper, _cacheManagerService);
            PropertyStatusRepository = new PropertyStatusRepository(_context, _mapper, _cacheManagerService);
            TransactionTypeRepository = new TransactionTypeRepository(_context, _mapper, _cacheManagerService);
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
