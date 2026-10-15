using System.ComponentModel.DataAnnotations.Schema;

namespace HouyarRealState.Domain.Entities.Article
{
    public class BlogInCategory : BaseEntity
    {
        public Guid BlogId { get; set; }
        public Guid BlogCategoryId { get; set; }
        public bool DefaultCategory { get; set; }
        //Start Relations

        #region Relations
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }

        [ForeignKey("BlogCategoryId")]
        public virtual BlogCategory BlogCategory { get; set; }
        #endregion
        //End Relations
    }
}
