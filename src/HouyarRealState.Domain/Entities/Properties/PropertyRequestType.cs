namespace HouyarRealState.Domain.Entities.Properties
{
    public class PropertyRequestType:BaseEntity
    {
        // عنوان نوع درخواست: عرضه یا تقاضا
        public string Title { get; set; } = string.Empty;

        // کد ثابت نوع آگهی: Offer یا Demand
        public string Code { get; set; } = string.Empty;

        #region Relations
        public virtual ICollection<Property> Properties { get; set; }
        #endregion
    }
}
