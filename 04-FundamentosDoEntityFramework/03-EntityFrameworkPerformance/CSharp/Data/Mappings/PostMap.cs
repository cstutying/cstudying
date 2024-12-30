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
      .WithMany(x => x.Posts)
      .HasConstraintName("FK_Post_Category")
      .OnDelete(DeleteBehavior.Cascade);

    // MAPEAMENTO MANY TO MANY
    builder.HasMany(x => x.Tags)
      .WithMany(x => x.Posts)
      .UsingEntity<Dictionary<string, object>>(
        "PostTag",
        post => post.HasOne<Tag>()
          .WithMany()
          .HasForeignKey("PostId")
          .HasConstraintName("FK_PostTag_PostId")
          .OnDelete(DeleteBehavior.Cascade),
        tag => tag.HasOne<Post>()
          .WithMany()
          .HasForeignKey("TagId")
          .HasConstraintName("FK_PostTag_TagId")
          .OnDelete(DeleteBehavior.Cascade));
  }
}