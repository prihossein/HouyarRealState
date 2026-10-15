using System.ComponentModel.DataAnnotations;
using HouyarRealState.Domain.Entities.Article;
using HouyarRealState.Domain.Entities.Properties;
using Microsoft.AspNetCore.Identity;

namespace HouyarRealState.Domain.Entities.User
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string Code { get; set; }
        public string? Mobile { get; set; }
        public string? FullName { get; set; }

        [Display(Name = "وضعیت موبایل")]
        public bool IsConfirmedMobile { get; set; }

        [Display(Name = "مسدود")]
        public bool IsBan { get; set; }

        public bool IsDelete { get; set; }

        public string? OTPCode { get; set; }

        public DateTime OTPCodeExpireDateTime { get; set; }

        [Display(Name = "آخرین ورود")]
        [DataType(DataType.DateTime)]
        public DateTime LastLogin { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime RegisterDate { get; set; }
        public DateTime LastOTPSentDate { get; set; }

        #region Relation
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
        #endregion
    }
}
