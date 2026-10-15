using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Marketing
{
    public class NewsletterSubscriberDTO:BaseDTO
    {
        public string Email { get; set; } = string.Empty;

        public DateTime SubscribedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;
    }
}
