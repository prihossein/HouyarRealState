using System.ComponentModel.DataAnnotations;
using HouyarRealState.Domain.Entities.Settings;
using HouyarRealState.Domain.Entities.User;

namespace HouyarRealState.Domain.Entities.Article
{
    public class Blog : BaseEntity
    {

     
        public Guid AspNetUserId { get; set; }

        public Guid LanguageId { get; set; }

        public string? BlogCode { get; set; }

        [Display(Name = "لینک کوتاه")]
        public string? ShortLink { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "{0} را وارد کنید", AllowEmptyStrings = false)]
        public string Title { get; set; }

        public string? Url { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "{0} را وارد کنید", AllowEmptyStrings = false)]
        public string Description { get; set; }

        [Display(Name = "عنوان سئو")]
        public string? SEOTitle { get; set; }

        [Display(Name = "توضیحات متا")]
        public string? MetaDescription { get; set; }

        [Display(Name = "لینک کنونیکال")]
        public string? CanonicalLink { get; set; }

        [Display(Name = "از موتورهای جستجو درخواست کن محتوای این صفحه را بررسی نکنند")]
        public bool IsNoIndex { get; set; }

        [Display(Name = "وضعیت دیدگاه")]
        public bool IsEnabledComment { get; set; }


        [Display(Name = "تاریخ ساخت")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "آخرین بروزرسانی")]
        public DateTime? ModifyDate { get; set; }

        [Display(Name = "تصویر شاخص")]
        public string? ThumbnailImageName { get; set; }
        public string? SmallThumbnailImageName { get; set; }

        [Display(Name = "متن جایگزین تصویر شاخص")]
        public string? AltThumbnail { get; set; }

        public bool IsDraft { get; set; }

        #region Relations

        public virtual Language Language { get; set; }
        public virtual ICollection<BlogInCategory> BlogInCategories { get; set; }
        public virtual ICollection<BlogInTag> BlogInTags { get; set; }
        public virtual ICollection<BlogFAQ> BlogFAQs { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public virtual ICollection<BlogComment> BlogComments { get; set; }
        #endregion
    }
}
