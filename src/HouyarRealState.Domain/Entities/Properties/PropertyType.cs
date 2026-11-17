namespace HouyarRealState.Domain.Entities.Properties
{
    public class PropertyType:BaseEntity
    {
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        #region Relations
        public virtual ICollection<Property> Properties { get; set; }
        #endregion

    }
}
