namespace HouyarRealState.Domain.Entities.Marketing
{
    public class NewsletterSubscriber:BaseEntity
    {
        public string Email { get; set; } = string.Empty;

        public DateTime SubscribedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;
    }
}
