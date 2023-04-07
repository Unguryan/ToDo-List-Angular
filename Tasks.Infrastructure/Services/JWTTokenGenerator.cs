using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Tasks.App.Services;
using Tasks.Domain.Models;

namespace Tasks.Infrastructure.Services
{
    public class JWTTokenGenerator : IJWTTokenGenerator
    {
        public Task<string> GenerateTokenAsync(User user)
        {
            var mySecret = "TestSecretKey-TestSecretKey-TestSecretKey";
            var mySecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(mySecret));

            var myIssuer = "http://localhost:5000/";

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim("UserId", user.Id.ToString()),
                    new Claim("GitHub", user.GitHubUserName),
                    new Claim("Telegram", user.TelegramId),
                    new Claim("Username", user.Username),
                }),

                Expires = DateTime.UtcNow.AddDays(7),
                Issuer = myIssuer,
                SigningCredentials = new SigningCredentials(mySecurityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return Task.FromResult(tokenHandler.WriteToken(token));
        }
    }
}
