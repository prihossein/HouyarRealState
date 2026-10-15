using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Articles
{
    public class BlogFAQDTO:BaseDTO
    {
        public Guid BlogId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
