using System;
using System.Collections.Generic;
using System.Text;

namespace HouyarRealState.Domain.Entities.Settings.Footer
{
    public class FooterMenuItem:BaseEntity
    {
        public Guid FooterMenuId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        #region Relations
        public virtual FooterMenu FooterMenu { get; set; }
        #endregion

    }
}
