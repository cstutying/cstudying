using CSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharp.Data;

public class CSharpDataContext : DbContext
{
  public DbSet<Category> Categories { get; set; }
  public DbSet<Post> Posts { get; set; }
  public DbSet<User> Users { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlServer("Server=DESKTOP-ON9P9QD\\SQLEXPRESS;Database=Blog;" +
                            "Trusted_Connection=True;TrustServerCertificate=True;");
}