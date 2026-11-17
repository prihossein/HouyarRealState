namespace HouyarRealState.Domain.Entities.Properties
{
    public class PropertyInFeature : BaseEntity
    {
        public Guid PropertyId { get; set; }
        public Guid PropertyFeatureId { get; set; }


        #region Relations
        public virtual Property Property { get; set; }
        public virtual PropertyFeature PropertyFeature { get; set; }
        #endregion

    }
}
