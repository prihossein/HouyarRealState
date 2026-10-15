using HouyarRealState.Domain.Entities.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Blog
{
    public class BlogInTagConfiguration : IEntityTypeConfiguration<BlogInTag>
    {
        public void Configure(EntityTypeBuilder<BlogInTag> builder)
        {
        // Table
        builder.ToTable("BlogInTags");

        // Primary Key
        builder.HasKey(x => x.Id);

        // Properties
        builder.Property(x => x.BlogId)
            .IsRequired();

        builder.Property(x => x.BlogTagId)
            .IsRequired();

        // Relationship: BlogInTag -> Blog
        builder.HasOne(x => x.Blog)
            .WithMany(x => x.BlogInTags)
            .HasForeignKey(x => x.BlogId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relationship: BlogInTag -> BlogTag
        builder.HasOne(x => x.BlogTag)
            .WithMany(x => x.BlogInTags)
            .HasForeignKey(x => x.BlogTagId)
            .OnDelete(DeleteBehavior.Cascade);

        // Prevent duplicate Blog-Tag relationships
        builder.HasIndex(x => new
        {
            x.BlogId,
            x.BlogTagId
        })
        .IsUnique();

        // Indexes
        builder.HasIndex(x => x.BlogId);

        builder.HasIndex(x => x.BlogTagId);
        }
    }
}
