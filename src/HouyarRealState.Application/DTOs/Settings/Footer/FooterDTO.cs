using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Settings.Footer
{
    public class FooterDTO:BaseDTO
    {
        public Guid LanguageId { get; set; }
        public string? ShortDescription { get; set; }
        public string? Address { get; set; }
        public string? Mobile { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
