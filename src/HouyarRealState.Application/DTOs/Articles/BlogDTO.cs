using System.ComponentModel.DataAnnotations;
using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Articles
{
    public class BlogDTO : BaseDTO
    {
        public Guid AspNetUserId { get; set; }

        public Guid LanguageId { get; set; }

        public string? BlogCode { get; set; }


        public string? ShortLink { get; set; }
        public string Title { get; set; }

        public string? Url { get; set; }

        public string Description { get; set; }


        public string? SEOTitle { get; set; }

        public string? MetaDescription { get; set; }


        public string? CanonicalLink { get; set; }
        public bool IsNoIndex { get; set; }
        public bool IsEnabledComment { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public string? ThumbnailImageName { get; set; }
        public string? SmallThumbnailImageName { get; set; }

        public string? AltThumbnail { get; set; }

        public bool IsDraft { get; set; }
    }
}
