using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Articles
{
    public class BlogCommentDTO:BaseDTO
    {
        public Guid BlogId { get; set; }
        public Guid? ParentId { get; set; }


        public Guid AspNetUserId { get; set; }
        public string Comment { get; set; }

        public bool IsSeen { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
