using System;
using System.Collections.Generic;
using System.Text;
using HouyarRealState.Domain.Entities.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Blog
{
    public class BlogTagConfiguration : IEntityTypeConfiguration<BlogTag>
    {
        public void Configure(EntityTypeBuilder<BlogTag> builder)
        {
            // Table
            builder.ToTable("BlogTags");

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.Tag)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.TagUrl)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            // Relationship: BlogTag -> BlogInTags
            builder.HasMany(x => x.BlogInTags)
                .WithOne(x => x.BlogTag)
                .HasForeignKey(x => x.BlogTagId)
                .OnDelete(DeleteBehavior.NoAction);

            // Indexes
            builder.HasIndex(x => x.TagUrl)
                .IsUnique();

            builder.HasIndex(x => x.IsDelete);
        }
    }
}
