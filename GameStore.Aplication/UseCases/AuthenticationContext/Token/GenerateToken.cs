using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GameStore.Aplication.UseCases.AuthenticationContext.Token
{
    public class GenerateToken(string secretKey)
    {
        private readonly string _secretKey = secretKey;

        public Task<string> Execute(Guid id)
        {
            var key = Encoding.ASCII.GetBytes(_secretKey);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
               [
                    new Claim("Id", id.ToString()),
               ]),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            string tokenString = tokenHandler.WriteToken(token);
            return Task.FromResult(tokenString);
        }
    }
}
