namespace HouyarRealState.Domain.Entities.Settings.Footer
{
    public class Footer:BaseEntity
    {
        public Guid LanguageId { get; set; }
        public string? ShortDescription { get; set; }
        public string? Address { get; set; }
        public string? Mobile { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        #region Relation
        public virtual Language Language { get; set; }
        public virtual ICollection<FooterMenu> FooterMenus { get; set; }
        #endregion
    }
}
