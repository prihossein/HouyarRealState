using System;
using System.Collections.Generic;
using System.Text;

namespace HouyarRealState.Application.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IPropertyRepository PropertyRepository { get; }
        Task ComplateAsync();
    }
}
