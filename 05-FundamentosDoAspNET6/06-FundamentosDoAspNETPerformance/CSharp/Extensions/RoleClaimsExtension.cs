using System.Security.Claims;
using CSharp.Models;

namespace CSharp.Extensions;

public static class RoleClaimsExtension
{
  public static IEnumerable<Claim> GetClaims(this User user)
  {
    var result = new List<Claim>
    {
      new(ClaimTypes.Name, user.Email) // vai ser usado como User.Identity.Email
    };
    result.AddRange(
      user.Roles.Select(role => new Claim(ClaimTypes.Role, role.Slug))
    );
    return result;
  }
}