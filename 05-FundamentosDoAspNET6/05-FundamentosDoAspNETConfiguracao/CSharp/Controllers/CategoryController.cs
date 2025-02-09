using CSharp.Data;
using CSharp.Extensions;
using CSharp.Models;
using CSharp.ViewModels;
using CSharp.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CSharp.Controllers;

[ApiController]
public class CategoryController : ControllerBase
{
  [HttpGet("v1/categories")]
  public async Task<IActionResult> GetAsync(
    [FromServices] CSharpDataContext context)
  {
    try
    {
      var categories = await context.Categories.ToListAsync();
      return Ok(new ResultViewModel<List<Category>>(categories));
    }
    catch
    {
      return StatusCode(500, new ResultViewModel<List<Category>>("05X15 - Falha interna no servidor"));
    }
  }


  [HttpGet("v1/categories/{id:int}")]
  public async Task<IActionResult> GetByIdAsync(
    [FromRoute] int id,
    [FromServices] CSharpDataContext context)
  {
    try
    {
      var category = await context
        .Categories
        .FirstOrDefaultAsync(x => x.Id == id);

      if (category == null)
        return NotFound(new ResultViewModel<Category>("05X13 - Conteúdo não encontrado"));

      return Ok(new ResultViewModel<Category>(category));
    }
    catch (Exception ex)
    {
      return StatusCode(500, new ResultViewModel<Category>("05X14 - Falha interna no servidor"));
    }
  }


  [HttpPost("v1/categories")]
  public async Task<IActionResult> PostAsync(
    [FromBody] EditorCategoryViewModel model,
    [FromServices] CSharpDataContext context)
  {
    if (!ModelState.IsValid)
      return BadRequest(new ResultViewModel<Category>(ModelState.GetErrors()));

    try
    {
      var category = new Category
      {
        Id = 0,
        Name = model.Name,
        Slug = model.Slug.ToLower(),
      };
      await context.Categories.AddAsync(category);
      await context.SaveChangesAsync();

      return Created($"v1/categories/{category.Id}", new ResultViewModel<Category>(ModelState.GetErrors()));
    }
    catch (DbUpdateException ex)
    {
      return StatusCode(500, new ResultViewModel<Category>("05XE8 - Não foi possível incluir a categoria"));
    }
    catch
    {
      return StatusCode(500, new ResultViewModel<Category>("05XE9 - Falha interna no servidor"));
    }
  }


  [HttpPut("v1/categories/{id:int}")]
  public async Task<IActionResult> PutAsync(
    [FromRoute] int id,
    [FromBody] EditorCategoryViewModel model,
    [FromServices] CSharpDataContext context)
  {
    try
    {
      var category = await context
        .Categories
        .FirstOrDefaultAsync(x => x.Id == id);

      if (category == null)
        return NotFound(new ResultViewModel<Category>("05X12 - Conteúdo não encontrado"));

      category.Name = model.Name;
      category.Slug = model.Slug;

      context.Categories.Update(category);
      await context.SaveChangesAsync();

      return Ok(model);
    }
    catch (DbUpdateException ex)
    {
      return StatusCode(500, new ResultViewModel<Category>("05XE10 - Não foi possível alterar a categoria"));
    }
    catch (Exception ex)
    {
      return StatusCode(500, new ResultViewModel<Category>("05XE11 - Falha interna no servidor"));
    }
  }


  [HttpDelete("v1/categories/{id:int}")]
  public async Task<IActionResult> DeleteAsync(
    [FromRoute] int id,
    [FromServices] CSharpDataContext context)
  {
    try
    {
      var category = await context
        .Categories
        .FirstOrDefaultAsync(x => x.Id == id);

      if (category == null)
        return NotFound(new ResultViewModel<Category>("05X16 - Conteúdo não encontrado"));

      context.Categories.Remove(category);
      await context.SaveChangesAsync();

      return Ok(new ResultViewModel<Category>(category));
    }
    catch (DbUpdateException ex)
    {
      return StatusCode(500, new ResultViewModel<Category>("05XE12 - Não foi possível Excluir a categoria"));
    }
    catch (Exception ex)
    {
      return StatusCode(500, new ResultViewModel<Category>("05XE13 - Falha interna no servidor"));
    }
  }
}