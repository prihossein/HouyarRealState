namespace HouyarRealState.Domain.Entities.Properties
{
    public class PropertyFeature: BaseEntity
    {
        public string Title { get; set; }


        #region Relations
        public virtual ICollection<PropertyInFeature> PropertyInFeatures { get; set; }
        #endregion


    }
}
