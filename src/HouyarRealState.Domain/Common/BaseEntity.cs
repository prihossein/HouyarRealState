using System.ComponentModel.DataAnnotations;

namespace HouyarRealState.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public bool IsDelete { get; set; }
    }
}
