using CSharp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
  public class UserMap : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      // Tabela
      builder.ToTable("User");

      // Chave Primária
      builder.HasKey(x => x.Id);

      // Identity
      builder.Property(x => x.Id)
        .ValueGeneratedOnAdd()
        .UseIdentityColumn();

      // Propriedades
      builder.Property(x => x.Name)
        .IsRequired()
        .HasColumnName("Name")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(80);

      // Bio
      builder.Property(x => x.Bio);
      builder.Property(x => x.Email);
      builder.Property(x => x.Image);
      builder.Property(x => x.PasswordHash);

      // Slug
      builder.Property(x => x.Slug)
        .IsRequired()
        .HasColumnName("Slug")
        .HasColumnType("VARCHAR")
        .HasMaxLength(80);

      // Indices
      builder
        .HasIndex(x => x.Slug, "IX_User_Slug")
        .IsUnique();

      // Mapeamento do User com Role
      builder
        .HasMany(x => x.Roles)
        .WithMany(x => x.Users)
        .UsingEntity<Dictionary<string, object>>(
          "UserRole",
          role => role
            .HasOne<Role>()
            .WithMany()
            .HasForeignKey("RoleId")
            .HasConstraintName("FK_UserRole_RoleId")
            .OnDelete(DeleteBehavior.Cascade),
          user => user
            .HasOne<User>()
            .WithMany()
            .HasForeignKey("UserId")
            .HasConstraintName("FK_UserRole_UserId")
            .OnDelete(DeleteBehavior.Cascade));
    }
  }
}