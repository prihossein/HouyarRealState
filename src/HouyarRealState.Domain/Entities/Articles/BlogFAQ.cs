using System.ComponentModel.DataAnnotations.Schema;

namespace HouyarRealState.Domain.Entities.Article
{
    public class BlogFAQ:BaseEntity
    {
        public Guid BlogId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        #region Relations
        public virtual Blog Blog { get; set; }
        #endregion

    }
}
