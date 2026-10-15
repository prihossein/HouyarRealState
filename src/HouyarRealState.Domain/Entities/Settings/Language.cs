using HouyarRealState.Domain.Entities.Article;
using HouyarRealState.Domain.Entities.Pages;
using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Domain.Entities.Settings
{
    public class Language : BaseEntity
    {
        // نام زبان؛ مانند فارسی یا English
        public string Name { get; set; } = string.Empty;

        // کد زبان بر اساس استاندارد ISO؛ مانند fa، en و ar
        public string Code { get; set; } = string.Empty;

        // کد منطقه‌ای زبان؛ مانند fa-IR یا en-US
        public string Culture { get; set; }

        // نام زبان به زبان اصلی خودش؛ مانند فارسی یا العربية
        public string NativeName { get; set; } = string.Empty;

        // مسیر یا نام فایل پرچم زبان
        public string Flag { get; set; }

        // آیا زبان از راست به چپ نوشته می‌شود؟
        public bool IsRtl { get; set; }

        // آیا این زبان، زبان پیش‌فرض سایت است؟
        public bool IsDefault { get; set; }

        // آیا این زبان در سایت فعال است؟
        public bool IsActive { get; set; } = true;


        #region Relations
        public virtual ICollection<TopBar> TopBars { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<BlogCategory> BlogCategories { get; set; }
        public virtual ICollection<HomePage> HomePages { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
        public virtual ICollection<PropertyCategory> PropertyCategories { get; set; }
        public virtual ICollection<Footer.Footer> Footers { get; set; }
        #endregion
    }
}
