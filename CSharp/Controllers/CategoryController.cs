using CSharp.Data;
using CSharp.Models;
using CSharp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharp.Controllers;

[ApiController]
public class CategoryController : ControllerBase
{
  [HttpGet("v1/categories")]
  public async Task<IActionResult> GetAsync(
    [FromServices]CSharpDataContext context)
  {
    try
    {
      var categories = await context.Categories.ToListAsync();
      return Ok(categories);
    }
    catch(Exception ex)
    {
      return StatusCode(500,"05X15 - Falha interna no servidor");
    }
  }
  
  
  [HttpGet("v1/categories/{id:int}")]
  public async Task<IActionResult> GetByIdAsync(
    [FromRoute] int id,
    [FromServices]CSharpDataContext context)
  {
    try
    {
      var category = await context
        .Categories
        .FirstOrDefaultAsync(x => x.Id == id);

      if (category == null)
        return NotFound();
    
      return Ok(category);
    }
    catch(Exception ex)
    {
      return StatusCode(500,"05X14 - Falha interna no servidor");
    }
  }
  
  
  [HttpPost("v1/categories")]
  public async Task<IActionResult> PostAsync(
    [FromBody] EditorCategoryViewModel model,
    [FromServices]CSharpDataContext context)
  {
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

      return Created($"v1/categories/{category.Id}", category);
    }
    catch (DbUpdateException ex)
    {
      return StatusCode(500, "05XE8 - Não foi possível incluir a categoria");
    }
    catch(Exception ex)
    {
      return StatusCode(500,"05XE9 - Falha interna no servidor");
    }
  }
  
  
  [HttpPut("v1/categories/{id:int}")]
  public async Task<IActionResult> PutAsync(
    [FromRoute]int id,
    [FromBody] EditorCategoryViewModel model,
    [FromServices]CSharpDataContext context)
  {
    if (!ModelState.IsValid)
      return BadRequest();
    
    try
    {
      var category = await context
        .Categories
        .FirstOrDefaultAsync(x => x.Id == id);
    
      if(category == null)
        return NotFound();

      category.Name = model.Name;
      category.Slug = model.Slug;

      context.Categories.Update(category);
      await context.SaveChangesAsync();
    
      return Ok(model);
    }
    catch (DbUpdateException ex)
    {
      return StatusCode(500, "05XE10 - Não foi possível alterar a categoria");
    }
    catch(Exception ex)
    {
      return StatusCode(500,"05XE11 - Falha interna no servidor");
    }
  }
  
  
  [HttpDelete("v1/categories/{id:int}")]
  public async Task<IActionResult> DeleteAsync(
    [FromRoute]int id,
    [FromServices]CSharpDataContext context)
  {
    try
    {
      var category = await context
        .Categories
        .FirstOrDefaultAsync(x => x.Id == id);
    
      if(category == null)
        return NotFound();

      context.Categories.Remove(category);
      await context.SaveChangesAsync();
    
      return Ok(category);
    }
    catch (DbUpdateException ex)
    {
      return StatusCode(500, "05XE12 - Não foi possível Excluir a categoria");
    }
    catch(Exception ex)
    {
      return StatusCode(500,"05XE13 - Falha interna no servidor");
    }
  }
}