using HouyarRealState.Domain.Entities.User;

namespace HouyarRealState.Domain.Entities.Properties
{
    public class Property:BaseEntity
    {
        // شناسه کاربری که آگهی ملک را ثبت کرده است
        public Guid AgentId { get; set; }

        public Guid PropertyRequestTypeId { get; set; }

        // نوع ملک: آپارتمان، خانه، ویلا، زمین، مغازه و غیره
        public Guid PropertyTypeId { get; set; }

        // نوع معامله: خرید، فروش، رهن، اجاره، تهاطر و ...
        public Guid TransactionTypeId { get; set; }
        public Guid PropertyStatusId { get; set; }


        public string Code { get; set; }

        // عنوان آگهی ملک
        public string? Title { get; set; } = string.Empty;

        // نام مالک
        public string? OwnerName { get; set; } = string.Empty;

        // توضیحات کامل ملک
        public string? Description { get; set; } = string.Empty;

        // کد نوسازی ملک در شهرداری
        public string? RenovationCode { get; set; }

        public string Address { get; set; }
        public string? OwnerMobileNumber { get; set; }


        public bool IsDraft { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }


        // حداقل قیمت هر مترمربع
        public double? MinPricePerMeter { get; set; }

        // حداکثر قیمت هر مترمربع
        public double? MaxPricePerMeter { get; set; }

        // حداقل قیمت کل ملک
        public double? MinTotalPrice { get; set; }

        // حداکثر قیمت کل ملک
        public double? MaxTotalPrice { get; set; }

        // عرض جغرافیایی (Latitude)
        public double? Latitude { get; set; }

        // طول جغرافیایی (Longitude)
        public double? Longitude { get; set; }

        // مساحت کل ملک بر حسب مترمربع
        public decimal? Area { get; set; }

        // مساحت زیربنا بر حسب مترمربع
        public decimal? BuiltArea { get; set; }


        #region Relations
        public virtual ApplicationUser Agent { get; set; }
        public virtual PropertyType PropertyType { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public virtual PropertyRequestType PropertyRequestType { get; set; }
        public virtual PropertyStatus PropertyStatus { get; set; }
        public virtual ICollection<PropertyInFeature> PropertyInFeatures { get; set; }
        #endregion

    }
}