using HouyarRealState.Domain.Entities.Article;
using Microsoft.EntityFrameworkCore;
using HouyarRealState.Domain.Entities.Article;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Blog
{
    public class BlogConfiguration : IEntityTypeConfiguration<HouyarRealState.Domain.Entities.Article.Blog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<HouyarRealState.Domain.Entities.Article.Blog> builder)
        {
            // Table
            builder.ToTable("Blogs");

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.AspNetUserId)
                .IsRequired();

            builder.Property(x => x.LanguageId)
                .IsRequired();

            builder.Property(x => x.BlogCode)
                .HasMaxLength(100);

            builder.Property(x => x.ShortLink)
                .HasMaxLength(250);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(x => x.Url)
                .HasMaxLength(500);

            builder.Property(x => x.Description)
                .IsRequired();

            builder.Property(x => x.SEOTitle)
                .HasMaxLength(300);

            builder.Property(x => x.MetaDescription)
                .HasMaxLength(500);

            builder.Property(x => x.CanonicalLink)
                .HasMaxLength(500);

            builder.Property(x => x.IsNoIndex)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.IsEnabledComment)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(x => x.CreateDate)
                .IsRequired();

            builder.Property(x => x.ModifyDate)
                .IsRequired(false);

            builder.Property(x => x.ThumbnailImageName)
                .HasMaxLength(300);

            builder.Property(x => x.SmallThumbnailImageName)
                .HasMaxLength(300);

            builder.Property(x => x.AltThumbnail)
                .HasMaxLength(300);

            builder.Property(x => x.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.IsDraft)
                .IsRequired()
                .HasDefaultValue(true);

            // Relationships

            // Blog -> Language
            builder.HasOne(x => x.Language)
                .WithMany()
                .HasForeignKey(x => x.LanguageId)
                .OnDelete(DeleteBehavior.NoAction);

            // Blog -> Author (ApplicationUser)
            builder.HasOne(x => x.Author)
                .WithMany()
                .HasForeignKey(x => x.AspNetUserId)
                .OnDelete(DeleteBehavior.NoAction);

            // Blog -> BlogInCategories
            builder.HasMany(x => x.BlogInCategories)
                .WithOne(x => x.Blog)
                .HasForeignKey(x => x.BlogId)
                .OnDelete(DeleteBehavior.NoAction);

            // Blog -> BlogFAQs
            builder.HasMany(x => x.BlogFAQs)
                .WithOne(x => x.Blog)
                .HasForeignKey(x => x.BlogId)
                .OnDelete(DeleteBehavior.NoAction);

            // Blog -> BlogComments
            builder.HasMany(x => x.BlogComments)
                .WithOne(x => x.Blog)
                .HasForeignKey(x => x.BlogId)
                .OnDelete(DeleteBehavior.NoAction);

            // Indexes
            builder.HasIndex(x => x.LanguageId);

            builder.HasIndex(x => x.AspNetUserId);

            builder.HasIndex(x => x.Url);

            builder.HasIndex(x => x.BlogCode);
        }
    }
}
