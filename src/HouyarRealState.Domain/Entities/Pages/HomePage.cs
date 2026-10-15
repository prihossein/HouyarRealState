

using HouyarRealState.Domain.Entities.Settings;

namespace HouyarRealState.Domain.Entities.Pages
{
    public class HomePage : BaseEntity
    {
        public Guid LanguageId { get; set; }
        public string? SeoTitle { get; set; }
        public string? MetaDescription { get; set; }

        public virtual Language Language { get; set; }
    }
}
