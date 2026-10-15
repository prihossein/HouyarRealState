using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Settings.Footer
{
    public class FooterMenuItemDTO : BaseDTO
    {
        public Guid FooterMenuId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
