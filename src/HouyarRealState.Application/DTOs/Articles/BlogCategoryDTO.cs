using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Articles
{
    public class BlogCategoryDTO:BaseDTO
    {
        public Guid LanguageId { get; set; }


        public Guid? ParentId { get; set; }


        public string TitleCategory { get; set; }


        public string? Description { get; set; }
        public string? ShortDescription { get; set; }

        public string Url { get; set; }
        public string? ThumbnailImageName { get; set; }
        public string? SmallThumbnailImageName { get; set; }
        public string? AltThumbnailImage { get; set; }

        public bool IsUncategorized { get; set; }
        public string? SEOTitle { get; set; }
 
        public string? MetaDescription { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
