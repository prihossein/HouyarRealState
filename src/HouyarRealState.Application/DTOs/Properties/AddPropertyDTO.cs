using System.ComponentModel.DataAnnotations;

namespace HouyarRealState.Application.DTOs.Properties
{
    public class AddPropertyDTO
    {
        // شناسه کاربری که آگهی ملک را ثبت کرده است

        [Display(Name = "مشاوره")]
        [Required(ErrorMessage = "{0} را انتخاب کنید"  ,AllowEmptyStrings = false)]
        public Guid AgentId { get; set; }

        [Display(Name = "نوع درخواست")]
        [Required(ErrorMessage = "{0} را انتخاب کنید", AllowEmptyStrings = false)]
        public Guid PropertyRequestTypeId { get; set; }

        // نوع ملک: آپارتمان، خانه، ویلا، زمین، مغازه و غیره
        [Display(Name = "نوع ملک")]
        [Required(ErrorMessage = "{0} را انتخاب کنید", AllowEmptyStrings = false)]
        public Guid PropertyTypeId { get; set; }

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "{0} را انتخاب کنید", AllowEmptyStrings = false)]
        public Guid PropertyStatusId { get; set; }

        // نوع معامله: خرید، فروش، رهن، اجاره، تهاطر و ...
        [Display(Name = "نوع معامله")]
        [Required(ErrorMessage = "{0} را انتخاب کنید", AllowEmptyStrings = false)]
        public Guid TransactionTypeId { get; set; }


        // عنوان آگهی ملک
        [Display(Name = "عنوان")]
        public string? Title { get; set; } = string.Empty;

        // توضیحات کامل ملک
        [Display(Name = "توضیحات")]
        public string? Description { get; set; } = string.Empty;

        // کد نوسازی ملک در شهرداری
        [Display(Name = "کد نوسازی")]
        public string? RenovationCode { get; set; }

        [Display(Name = "نام مالک")]
        public string? OwnerName { get; set; } = string.Empty;

        // حداقل قیمت هر مترمربع
        [Display(Name = "حداقل قیمت هر مترمربع")]
        public double? MinPricePerMeter { get; set; }

        // حداکثر قیمت هر مترمربع
        [Display(Name = "حداکثر قیمت هر مترمربع")]
        public double? MaxPricePerMeter { get; set; }

        // حداقل قیمت کل ملک
        [Display(Name = "حداقل قیمت کل ملک")]
        public double? MinTotalPrice { get; set; }

        // حداکثر قیمت کل ملک
        [Display(Name = "حداکثر قیمت کل ملک")]
        public double? MaxTotalPrice { get; set; }

        // عرض جغرافیایی (Latitude)
        [Display(Name = "عرض جغرافیایی (Latitude)")]
        public double? Latitude { get; set; }

        // طول جغرافیایی (Longitude)
        [Display(Name = "طول جغرافیایی (Longitude)")]
        public double? Longitude { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "{0} را وارد کنید", AllowEmptyStrings = false)]
        public string Address { get; set; }

        [Display(Name = "شماره مالک")]
        public string? OwnerMobileNumber { get; set; }

        // مساحت کل ملک بر حسب مترمربع
        [Display(Name = "مساحت کل ملک بر حسب مترمربع")]
        public decimal? Area { get; set; }

        // مساحت زیربنا بر حسب مترمربع
        [Display(Name = "مساحت زیربنا بر حسب مترمربع")]
        public decimal? BuiltArea { get; set; }

        [Display(Name = "امکانات")]
        public List<Guid>? PropertyFeature { get; set; } = new List<Guid>();
    }
}
