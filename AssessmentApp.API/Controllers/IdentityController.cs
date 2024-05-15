using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace AssessmentApp.API.Controllers
{
    public record TokenGenerationRequest(string UserId, string Email, JsonElement CustomClaims);
    public class IdentityController : ControllerBase
    {
        private const string TokenSecret = "ForTheLoveOfGodStoreAndLoadThisSecurely";
        private static readonly TimeSpan TokenLifeTime = TimeSpan.FromHours(8);

        [HttpPost("token")]
        public IActionResult GenerateToken([FromBody]TokenGenerationRequest request)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(TokenSecret);

            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(JwtRegisteredClaimNames.Sub, request.Email),
                new(JwtRegisteredClaimNames.Email, request.Email),
                new(ClaimTypes.Role, "role"),
                new("userid", request.UserId),
            };

            foreach(var p in request.CustomClaims.EnumerateObject())
            {
                JsonElement jsonElement = p.Value;
                var valueType = jsonElement.ValueKind switch
                {
                    JsonValueKind.True => ClaimValueTypes.Boolean,
                    JsonValueKind.False => ClaimValueTypes.Boolean,
                    JsonValueKind.Number => ClaimValueTypes.Double,
                    _ => ClaimValueTypes.String,
                };

                var claim = new Claim(p.Name, p.Value.ToString(), valueType);
                claims.Add(claim);
            }

            var tokenDescriptior = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(TokenLifeTime),
                Issuer = "https://id.dm.name",
                Audience = "https://assessment.onestream.test",
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256),
            };

            var token = tokenHandler.CreateToken(tokenDescriptior);

            string result = tokenHandler.WriteToken(token);
            return Ok(result);
        }
    }
}
