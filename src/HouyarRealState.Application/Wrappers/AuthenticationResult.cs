using Microsoft.AspNetCore.Identity;

namespace HouyarRealState.Application.Wrappers
{
    public class OTPResult
    {
        public string Message { get; set; }
        public SignInResult SignInResult { get; set; }
    }
    public class AuthenticationResult
    {
        public string Message { get; set; }
        public string UserId { get; set; }
        public SignInResult SignInResult { get; set; }
    }
}
