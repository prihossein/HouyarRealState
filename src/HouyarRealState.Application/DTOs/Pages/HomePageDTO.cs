using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Pages
{
    public class HomePageDTO:BaseDTO
    {
        public Guid LanguageId { get; set; }
        public string? SeoTitle { get; set; }
        public string? MetaDescription { get; set; }
    }
}
