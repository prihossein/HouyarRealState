namespace HouyarRealState.Domain.Entities.Properties
{
    public class TransactionType:BaseEntity
    {
        public string Title { get; set; }

        #region Relations
        public virtual ICollection<Property> Properties { get; set; }
        #endregion
    }
}
