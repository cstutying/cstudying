using CSharp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharp.Controllers;

[ApiController]
public class PostController : ControllerBase
{
  [HttpGet("v1/posts")]
  public async Task<IActionResult> GetAsync(
    [FromServices] CSharpDataContext context)
  {
    return Ok(await context.Posts.ToListAsync());
  }
}