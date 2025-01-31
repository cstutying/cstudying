using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CSharp.Models;
using Microsoft.IdentityModel.Tokens;

namespace CSharp.Services;

public class TokenService
{
  public string GenerateToken(User user)
  {
    var tokenHandler = new JwtSecurityTokenHandler();
    var key = Encoding.ASCII.GetBytes(Configuration.JwtKey);
    var tokenDescriptor = new SecurityTokenDescriptor
    {
      Subject = new ClaimsIdentity(new Claim[]
      {
        new(ClaimTypes.Name, "christianCsharp"), // vai ser usado como User.Identity.Name
        new(ClaimTypes.Role, "user"), // vai permitir o User.IsInRole("user")
        new(ClaimTypes.Role, "admin"), // vai permitir o User.IsInRole("admin")
        new("fruta", "banana")
      }),
      Expires = DateTime.UtcNow.AddHours(8),
      SigningCredentials = new SigningCredentials(
        new SymmetricSecurityKey(key),
        SecurityAlgorithms.HmacSha256Signature),
    };
    var token = tokenHandler.CreateToken(tokenDescriptor);
    return tokenHandler.WriteToken(token);
  }
}