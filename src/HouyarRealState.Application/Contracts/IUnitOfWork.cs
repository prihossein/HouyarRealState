using System;
using System.Collections.Generic;
using System.Text;

namespace HouyarRealState.Application.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IPropertyRepository PropertyRepository { get; }
        IAccountRepository AccountRepository { get; }
        IPropertyFeatureRepository PropertyFeatureRepository { get; }
        IPropertyStatusRepository PropertyStatusRepository { get; }
        ITransactionTypeRepository TransactionTypeRepository { get; }
        Task ComplateAsync();
    }
}
