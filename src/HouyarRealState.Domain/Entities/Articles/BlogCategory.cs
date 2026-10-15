using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HouyarRealState.Domain.Entities.Settings;

namespace HouyarRealState.Domain.Entities.Article
{
    public class BlogCategory : BaseEntity
    {
        public Guid LanguageId { get; set; }

        [Display(Name = "دسته بندی مادر")]
        public Guid? ParentId { get; set; }

        [Display(Name = "عنوان دسته بندی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}خود را وارد نمایید ")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string TitleCategory { get; set; }

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }

        [Display(Name = "آدرس اینترنتی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}خود را وارد نمایید ")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Url { get; set; }
        public string? ThumbnailImageName { get; set; }
        public string? SmallThumbnailImageName { get; set; }
        public string? AltThumbnailImage { get; set; }


        [Display(Name = "دسته بندی نشده")]
        public bool IsUncategorized { get; set; }

        [Display(Name = "عنوان سئو")]
        public string? SEOTitle { get; set; }

        [Display(Name = "توضیحات متا")]
        public string? MetaDescription { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        #region Relations

        public virtual ICollection<BlogCategory> BlogCategories { get; set; }
        public virtual ICollection<BlogInCategory> BlogInCategories { get; set; }

        public virtual Language Language { get; set; }

        #endregion
    }
}
