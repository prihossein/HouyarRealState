using System;
using System.Collections.Generic;
using System.Text;
using HouyarRealState.Domain.Entities.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Blog
{
    public class BlogCommentConfiguration : IEntityTypeConfiguration<BlogComment>
    {
        public void Configure(EntityTypeBuilder<BlogComment> builder)
        {
            // Table
            builder.ToTable("BlogComments");

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.BlogId)
                .IsRequired();

            builder.Property(x => x.Comment)
                .IsRequired()
                .HasMaxLength(1500);

            builder.Property(x => x.IsSeen)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.IsConfirm)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.CreateDate)
                .IsRequired();

            builder.Property(x => x.ParentId)
                .IsRequired(false);

            builder.Property(x => x.AspNetUserId)
                .IsRequired()
                .HasMaxLength(450);

            // Relationship: BlogComment -> Blog
            builder.HasOne(x => x.Blog)
                .WithMany(x => x.BlogComments)
                .HasForeignKey(x => x.BlogId)
                .OnDelete(DeleteBehavior.NoAction);

            // Self-referencing relationship: Parent -> Replies
            builder.HasOne<BlogComment>()
                .WithMany(x => x.BlogComments)
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship: BlogComment -> ApplicationUser
            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.AspNetUserId)
                .OnDelete(DeleteBehavior.NoAction);

            // Indexes
            builder.HasIndex(x => x.BlogId);

            builder.HasIndex(x => x.ParentId);

            builder.HasIndex(x => x.AspNetUserId);

            builder.HasIndex(x => new { x.BlogId, x.IsConfirm, x.IsDelete });
        }
    }
}
