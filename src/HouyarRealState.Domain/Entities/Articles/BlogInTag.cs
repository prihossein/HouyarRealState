using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouyarRealState.Domain.Entities.Article
{
    public class BlogInTag:BaseEntity
    {

        public Guid BlogTagId { get; set; }


        public Guid BlogId { get; set; }

        #region RelationShips
        public virtual BlogTag BlogTag { get; set; }

        public virtual Blog Blog { get; set; }
        #endregion
    }
}
