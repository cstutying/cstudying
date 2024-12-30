using Blog.Data.Mappings;
using CSharp.Data.Mappings;
using CSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharp.Data;

public class CSharpDataContext : DbContext
{
  public DbSet<Category> Categories { get; set; }
  public DbSet<Post> Posts { get; set; }
  public DbSet<User> Users { get; set; }

  public DbSet<PostWithTagsCount> PostWithTagsCounts { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlServer("Server=DESKTOP-ON9P9QD\\SQLEXPRESS;Database=Blog;" + "Trusted_Connection=True;" +
                            "TrustServerCertificate=True;");

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfiguration(new CategoryMap());
    modelBuilder.ApplyConfiguration(new PostMap());
    modelBuilder.ApplyConfiguration(new UserMap());

    modelBuilder.Entity<PostWithTagsCount>(x =>
    {
      x.ToSqlQuery(@"
        SELECT 
            [Title] AS [Name],
            SELECT COUNT([Id]) FROM [Tags] WHERE [PostId] = [Id] 
                AS [Count]
            FROM 
                [Posts]");
    });
  }
}