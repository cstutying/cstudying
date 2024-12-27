using Microsoft.EntityFrameworkCore;

namespace CSharp.Data;

public class CSharpDataContext : DbContext
{
  protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlServer("Server=DESKTOP-ON9P9QD\\SQLEXPRESS;Database=Blog;" + "Trusted_Connection=True;" +
                            "TrustServerCertificate=True;");
}