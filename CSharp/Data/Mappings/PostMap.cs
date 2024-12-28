using CSharp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;

namespace CSharp.Data.Mappings;

public class PostMap : IEntityTypeConfiguration<Post>
{
  public void Configure(EntityTypeBuilder<Post> builder)
  {
    builder.ToTable("Post");

    // Chave Primaria
    builder.HasKey(x => x.Id);

    // Identity
    builder.Property(x => x.Id)
      .ValueGeneratedOnAdd()
      .UseIdentityColumn();

    // Propriedades
    builder.Property(x => x.LastUpdateDate)
      .IsRequired()
      .HasColumnName("LastUpdateDate")
      .HasColumnType("SMALLDATETIME")
      .HasDefaultValueSql("GETDATE()");
    // .HasDefaultValue(DateTime.Now.ToUniversalTime());

    // INDICES
    builder
      .HasIndex(x => x.Slug, "IX_Post_Slug")
      .IsUnique();

    // Relacionamentos
    builder.HasOne(x => x.Author)
      .WithMany(x => x.Posts)
      .HasConstraintName("FK_Post_Author")
      .OnDelete(DeleteBehavior.Cascade);

    // Builder
    builder
      .HasOne(x => x.Category)
      .WithMany(x => x.Post)
      .HasConstraintName("FK_Post_Category")
      .OnDelete(DeleteBehavior.Cascade);
  }
}