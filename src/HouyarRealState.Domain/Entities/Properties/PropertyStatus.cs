using HouyarRealState.Domain.Common;
using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Domain.Entities.Properties
{
    public class PropertyStatus : BaseEntity
    {
        public string Title { get; set; }


        #region Relations
        public virtual ICollection<Property> Properties { get; set; }
        #endregion
    }
}
