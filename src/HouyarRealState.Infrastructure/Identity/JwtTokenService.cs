using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HouyarRealState.Application.DTOs.Identity;
using HouyarRealState.Domain.Entities.User;
using HouyarRealState.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace HouyarRealState.Infrastructure.Identity
{
    public class JwtTokenService
    {
        public readonly UserManager<ApplicationUser> _userManager;
        public readonly JwtOption _jwtOption;
        public readonly ApplicationDbContext _context;

        public JwtTokenService(UserManager<ApplicationUser> userManager, IOptions<JwtOption> jwtOption, ApplicationDbContext context)
        {
            _userManager = userManager;
            _jwtOption = jwtOption.Value;
            _context = context;
        }

        public async Task<JwtResultDTO> GenerateTokenAsync(GetTokenDTO dto)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Mobile == dto.Mobile);

            if (user == null)
            {
                throw new FluentValidation.ValidationException("نام کاربری یا کلمه عبور اشتباه است!", new List<FluentValidation.Results.ValidationFailure>());
            }

            if (await _userManager.CheckPasswordAsync(user, dto.Password))
            {
                var userClaims = await _userManager.GetClaimsAsync(user);
                var roles = await _userManager.GetRolesAsync(user);
                var roleClaims = new List<Claim>();

                foreach (var role in roles)
                {
                    roleClaims.Add(new Claim(ClaimTypes.Role, role));
                }

                var jwtClaims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub,user.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.GivenName,user.FullName),
                    new Claim("CustomClaim","CustomValue"),
                };


                var claims = userClaims
                    .Union(jwtClaims)
                    .Union(roleClaims)
                    .Union(userClaims);

                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOption.Key));
                var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var expireTime = DateTime.UtcNow.AddMinutes(_jwtOption.Expiration);

                var jwtSecurityToken = new JwtSecurityToken(
                    issuer: _jwtOption.Issuer,
                    audience: _jwtOption.Audience,
                    expires: expireTime,
                    signingCredentials: signingCredentials,
                    claims: claims
                    );

                return new JwtResultDTO
                {
                    Expiration = expireTime,
                    UserId = user.Id,
                    Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken)
                };
            }


            throw new FluentValidation.ValidationException("نام کاربری یا کلمه عبور اشتباه است!", new List<FluentValidation.Results.ValidationFailure>());




        }
    }
}
