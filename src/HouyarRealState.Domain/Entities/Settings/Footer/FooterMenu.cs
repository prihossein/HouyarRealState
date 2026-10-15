namespace HouyarRealState.Domain.Entities.Settings.Footer
{
    public class FooterMenu : BaseEntity
    {
        public Guid FooterId { get; set; }
        public string Title { get; set; }

        public virtual Footer Footer { get; set; }
        public virtual ICollection<FooterMenuItem> FooterMenuItems { get; set; }
    }
}
