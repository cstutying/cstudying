using CSharp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSharp.Data.Mappings;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
  public void Configure(EntityTypeBuilder<Category> builder)
  {
    builder.ToTable("Category");

    //Identity
    builder.HasKey(x => x.Id);
    builder.Property(x => x.Id)
      .ValueGeneratedOnAdd()
      .UseIdentityColumn();

    // Propriedades
    builder.Property(x => x.Name)
      .IsRequired()
      .HasColumnName("Name")
      .HasColumnType("NVARCHAR")
      .HasMaxLength(80);

    // Slug
    builder.Property(x => x.Slug)
      .IsRequired()
      .HasColumnName("Slug")
      .HasColumnType("VARCHAR")
      .HasMaxLength(80);

    // Indices
    builder.HasIndex(x => x.Slug, "IX_Category_Slug")
      .IsUnique();
  }
}