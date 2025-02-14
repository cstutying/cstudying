using CSharp.Data.Mappings;
using CSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharp.Data;

public class CSharpDataContext : DbContext
{
  public CSharpDataContext(DbContextOptions<CSharpDataContext>options)
  :base(options)
  {
    
  }
  public DbSet<Category> Categories { get; set; }
  public DbSet<Post> Posts { get; set; }
  public DbSet<User> Users { get; set; }
  

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfiguration(new CategoryMap());
    modelBuilder.ApplyConfiguration(new PostMap());
    modelBuilder.ApplyConfiguration(new UserMap());
  }
}