using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Settings.Footer
{
    public class FooterMenuDTO:BaseDTO
    {
        public Guid FooterId { get; set; }
        public string Title { get; set; }
    }
}
