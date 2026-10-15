using System.ComponentModel.DataAnnotations;

namespace HouyarRealState.Domain.Entities.Article
{
    public class BlogTag : BaseEntity
    {
        public string Tag { get; set; }

        public string TagUrl { get; set; }

        public virtual ICollection<BlogInTag> BlogInTags { get; set; }
    }
}
