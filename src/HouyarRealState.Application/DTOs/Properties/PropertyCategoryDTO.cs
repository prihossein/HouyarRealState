using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Properties
{
    public class PropertyCategoryDTO:BaseDTO
    {
        public Guid? ParentId { get; set; }
        public Guid LanguageId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public bool Uncategorized { get; set; }
        public string? Description { get; set; }
        public string? SEOTitle { get; set; }
        public bool IsDraft { get; set; }
        public string? MetaDescription { get; set; }
        public string? ThumbnailImageName { get; set; }
        public string? SmallThumbnailImageName { get; set; }
        public string? AltThumbnailImage { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
