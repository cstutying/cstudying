using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CSharp.Extensions;
using CSharp.Models;
using Microsoft.IdentityModel.Tokens;

namespace CSharp.Services;

public class TokenService
{
  public string GenerateToken(User user)
  {
    var tokenHandler = new JwtSecurityTokenHandler();
    var key = Encoding.ASCII.GetBytes(Configuration.JwtKey);
    var claims = user.GetClaims();
    var tokenDescriptor = new SecurityTokenDescriptor
    {
      Subject = new ClaimsIdentity(claims),
      Expires = DateTime.UtcNow.AddHours(8),
      SigningCredentials = new SigningCredentials(
        new SymmetricSecurityKey(key),
        SecurityAlgorithms.HmacSha256Signature),
    };
    var token = tokenHandler.CreateToken(tokenDescriptor);
    return tokenHandler.WriteToken(token);
  }
}