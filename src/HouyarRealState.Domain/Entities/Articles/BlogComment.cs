using System.ComponentModel.DataAnnotations;
using HouyarRealState.Domain.Entities.User;

namespace HouyarRealState.Domain.Entities.Article
{
    public class BlogComment : BaseEntity
    {
        public Guid BlogId { get; set; }
        public Guid? ParentId { get; set; }


        public Guid AspNetUserId { get; set; }
        public string Comment { get; set; }

        public bool IsSeen { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }



        #region Relations

        public virtual ICollection<BlogComment> BlogComments { get; set; }


        public virtual Blog Blog { get; set; }

        public virtual ApplicationUser User { get; set; }

        #endregion
    }
}
