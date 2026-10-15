using HouyarRealState.Domain.Entities.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Properies
{
    public class PropertyCategoryConfiguration : IEntityTypeConfiguration<PropertyCategory>
    {
        public void Configure(EntityTypeBuilder<PropertyCategory> builder)
        {
            // Table
            builder.ToTable("PropertyCategories");

            // Primary Key
            builder.HasKey(pc => pc.Id);

            // Title
            builder.Property(pc => pc.Title)
                .IsRequired()
                .HasMaxLength(200);

            // URL
            builder.Property(pc => pc.Url)
                .IsRequired()
                .HasMaxLength(250);

            // Description
            builder.Property(pc => pc.Description)
                .HasMaxLength(1000);

            // SEO
            builder.Property(pc => pc.SEOTitle)
                .HasMaxLength(70);

            builder.Property(pc => pc.MetaDescription)
                .HasMaxLength(160);

            // Images
            builder.Property(pc => pc.ThumbnailImageName)
                .HasMaxLength(255);

            builder.Property(pc => pc.SmallThumbnailImageName)
                .HasMaxLength(255);

            builder.Property(pc => pc.AltThumbnailImage)
                .HasMaxLength(255);

            // Language
            builder.Property(pc => pc.LanguageId)
                .IsRequired();

            builder.HasOne(pc => pc.Language)
                .WithMany()
                .HasForeignKey(pc => pc.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            // Parent Category
            builder.Property(pc => pc.ParentId)
                .IsRequired(false);

            builder.HasOne<PropertyCategory>()
                .WithMany()
                .HasForeignKey(pc => pc.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Default Values
            builder.Property(pc => pc.Uncategorized)
                .HasDefaultValue(false);

            builder.Property(pc => pc.IsDraft)
                .HasDefaultValue(false);

            builder.Property(pc => pc.CreateDate)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Indexes
            builder.HasIndex(pc => pc.LanguageId);

            builder.HasIndex(pc => pc.ParentId);

            builder.HasIndex(pc => pc.IsDraft);

            builder.HasIndex(pc => new
            {
                pc.LanguageId,
                pc.Url
            }).IsUnique();

            builder.HasIndex(pc => new
            {
                pc.LanguageId,
                pc.ParentId
            });
        }
    }
}
