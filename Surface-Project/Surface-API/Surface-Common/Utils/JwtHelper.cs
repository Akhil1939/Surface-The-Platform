using Microsoft.IdentityModel.Tokens;
using Surface.Common.Constants;
using Surface.Common.Utils.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;

namespace Surface.Common.Utils
{
    public class JwtHelper
    {
        public static string GenerateToken(JwtSetting jwtSetting, SessionUserModel sessionUserModel)
        {
            if (jwtSetting == null) return null;

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSetting.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name,sessionUserModel.Id.ToString()),
                new Claim(ClaimTypes.Email,sessionUserModel.Email),
                new Claim(ClaimTypes.Role,sessionUserModel.Role.ToString()),
                new Claim(ClaimTypes.NameIdentifier,sessionUserModel.Id.ToString()),
            };

            var authToken = new JwtSecurityToken(
                jwtSetting.Issuer,
                jwtSetting.Audience,
                claims,
                expires: DateTime.UtcNow.AddMinutes(jwtSetting.ExpiryMinutes),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(authToken);
        }

        public static ClaimsPrincipal? ValidateJwtToken(JwtSetting jwtSetting, string authToken)
        {
            if (IsTokenExpired(authToken))
            {
                throw new AuthenticationException(ExceptionMessage.TOKEN_EXPIRED);
            }
            JwtSecurityTokenHandler tokenHandler = new();
            byte[] key = Encoding.ASCII.GetBytes(jwtSetting.Key);

            TokenValidationParameters validationParameters = new()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = true,
                ValidateAudience = false,
                ValidIssuer = jwtSetting.Issuer,
                ClockSkew = TimeSpan.Zero
            };

            ClaimsPrincipal? principal = tokenHandler.ValidateToken(authToken, validationParameters, out var validatedToken);
            return principal;
        }
        public static DateTime GetTokenExpirationTime(string token)
        {
            JwtSecurityTokenHandler tokenHandler = new();
            JwtSecurityToken jwtSecurityToken = tokenHandler.ReadJwtToken(token);
            DateTime expirationTime = jwtSecurityToken.ValidTo;
            return expirationTime;
        }

        public static bool IsTokenExpired(string token)
        {
            DateTime expirationTime = GetTokenExpirationTime(token);
            return expirationTime <= DateTime.UtcNow;
        }
    }
}
