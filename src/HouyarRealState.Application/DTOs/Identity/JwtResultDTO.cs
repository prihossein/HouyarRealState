namespace HouyarRealState.Application.DTOs.Identity
{
    public class JwtResultDTO
    {
        public Guid UserId { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
