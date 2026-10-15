using HouyarRealState.Domain.Entities.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Blog
{
    public class BlogCategoryConfiguration : IEntityTypeConfiguration<BlogCategory>
    {
        public void Configure(EntityTypeBuilder<BlogCategory> builder)
        {
            // Table
            builder.ToTable("BlogCategories");

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.LanguageId)
                .IsRequired();

            builder.Property(x => x.ParentId)
                .IsRequired(false);

            builder.Property(x => x.TitleCategory)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Description)
                .IsRequired(false);

            builder.Property(x => x.ShortDescription)
                .IsRequired(false)
                .HasMaxLength(500);

            builder.Property(x => x.Url)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.ThumbnailImageName)
                .IsRequired(false)
                .HasMaxLength(300);

            builder.Property(x => x.SmallThumbnailImageName)
                .IsRequired(false)
                .HasMaxLength(300);

            builder.Property(x => x.AltThumbnailImage)
                .IsRequired(false)
                .HasMaxLength(300);

            builder.Property(x => x.IsUncategorized)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.SEOTitle)
                .IsRequired(false)
                .HasMaxLength(300);

            builder.Property(x => x.MetaDescription)
                .IsRequired(false)
                .HasMaxLength(500);

            builder.Property(x => x.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.CreateDate)
                .IsRequired();

            builder.Property(x => x.ModifyDate)
                .IsRequired(false);

            // Relationship: BlogCategory -> Language
            builder.HasOne(x => x.Language)
                .WithMany()
                .HasForeignKey(x => x.LanguageId)
                .OnDelete(DeleteBehavior.NoAction);

            // Self-referencing relationship: Parent -> Children
            builder.HasOne<BlogCategory>()
                .WithMany(x => x.BlogCategories)
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship: BlogCategory -> BlogInCategories
            builder.HasMany(x => x.BlogInCategories)
                .WithOne(x => x.BlogCategory)
                .HasForeignKey(x => x.BlogCategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            // Indexes
            builder.HasIndex(x => x.LanguageId);

            builder.HasIndex(x => x.ParentId);

            builder.HasIndex(x => new { x.LanguageId, x.Url })
                .IsUnique();

            builder.HasIndex(x => new { x.LanguageId, x.IsUncategorized });
        }
    }
}
