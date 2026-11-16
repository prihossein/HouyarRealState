using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using HouyarRealState.Application.DTOs.Settings;
using HouyarRealState.Application.DTOs.Settings.Footer;
using HouyarRealState.Domain.Entities.Settings;
using HouyarRealState.Domain.Entities.Settings.Footer;

namespace HouyarRealState.Application.Contracts
{
    public interface IFooterRepository : IGenericRepository<Footer>
    {
        Task<List<FooterDTO>?> Where(Expression<Func<Footer, bool>> predicate, CancellationToken cancellationToken = default);
        Task CreateAsync(FooterDTO dto);

        Task DeleteAsync(Guid id);

        Task<bool> ExistByIdAsync(Guid Id);

        Task<FooterDTO?> GetFooterByIdAsync(Guid Id);

        Task UpdateAsync(Guid id, FooterDTO dto);

        Task<List<FooterDTO>?> GetAllFootersAsync();
    }
}
