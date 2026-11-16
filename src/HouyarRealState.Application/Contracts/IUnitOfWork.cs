using System;
using System.Collections.Generic;
using System.Text;

namespace HouyarRealState.Application.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IFooterRepository FooterRepository { get; }
        ILanguageRepository LanguageRepository { get; }
        Task ComplateAsync();
    }
}
