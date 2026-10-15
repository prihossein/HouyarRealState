using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Articles
{
    public class BlogInCategoryDTO:BaseDTO
    {
        public Guid BlogId { get; set; }
        public Guid BlogCategoryId { get; set; }
        public bool DefaultCategory { get; set; }
    }
}
