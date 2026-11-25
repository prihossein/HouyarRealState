namespace HouyarRealState.Application.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IPropertyRepository PropertyRepository { get; }
        IAccountRepository AccountRepository { get; }
        IPropertyFeatureRepository PropertyFeatureRepository { get; }
        IPropertyStatusRepository PropertyStatusRepository { get; }
        ITransactionTypeRepository TransactionTypeRepository { get; }
        IPropertyRequestTypeRepository PropertyRequestTypeRepository { get; }
        IPropertyTypeRepository PropertyTypeRepository { get; }
        IPropertyInFeatureRepository PropertyInFeatureRepository { get; }
        Task ComplateAsync();
    }
}
