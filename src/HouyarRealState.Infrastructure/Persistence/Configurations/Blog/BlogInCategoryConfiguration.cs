using System;
using System.Collections.Generic;
using System.Text;
using HouyarRealState.Domain.Entities.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Blog
{
    public class BlogInCategoryConfiguration : IEntityTypeConfiguration<BlogInCategory>
    {
        public void Configure(EntityTypeBuilder<BlogInCategory> builder)
        {
            // Table
            builder.ToTable("BlogInCategories");

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.BlogId)
                .IsRequired();

            builder.Property(x => x.BlogCategoryId)
                .IsRequired();

            builder.Property(x => x.DefaultCategory)
                .IsRequired()
                .HasDefaultValue(false);

            // Relationship: BlogInCategory -> Blog
            builder.HasOne(x => x.Blog)
                .WithMany(x => x.BlogInCategories)
                .HasForeignKey(x => x.BlogId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relationship: BlogInCategory -> BlogCategory
            builder.HasOne(x => x.BlogCategory)
                .WithMany(x => x.BlogInCategories)
                .HasForeignKey(x => x.BlogCategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Prevent duplicate Blog-Category relationships
            builder.HasIndex(x => new
            {
                x.BlogId,
                x.BlogCategoryId
            })
            .IsUnique();

            // Indexes
            builder.HasIndex(x => x.BlogId);

            builder.HasIndex(x => x.BlogCategoryId);
        }
    }
}
