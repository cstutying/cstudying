using CSharp.Data;
using CSharp.ViewModels.Posts;
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
    var posts = await context
      .Posts
      .AsNoTracking()
      .Include(x => x.Category)
      .Include(x => x.Author)
      .Select(x => new ListPostsViewModel
      {
        Id = x.Id,
        Title = x.Title,
        Slug = x.Slug,
        LastUpdateDate = x.LastUpdateDate,
        Category = x.Category.Name,
        Author = $"{x.Author.Name} ({x.Author.Email})"
      })
      .ToListAsync();
    return Ok(posts);
  }
}