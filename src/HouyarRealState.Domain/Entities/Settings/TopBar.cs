namespace HouyarRealState.Domain.Entities.Settings
{
    public class TopBar:BaseEntity
    {
        public Guid LanguageId { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        #region Relations
        public virtual Language Language { get; set; }
        #endregion
    }
}
