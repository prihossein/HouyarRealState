using HouyarRealState.Domain.Entities.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Blog
{
    public class BlogFAQConfiguration : IEntityTypeConfiguration<BlogFAQ>
    {
        public void Configure(EntityTypeBuilder<BlogFAQ> builder)
        {
            // Table
            builder.ToTable("BlogFAQs");

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.BlogId)
                .IsRequired();

            builder.Property(x => x.Question)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.Answer)
                .IsRequired()
                .HasMaxLength(4000);

            // Relationship: BlogFAQ -> Blog
            builder.HasOne(x => x.Blog)
                .WithMany(x => x.BlogFAQs)
                .HasForeignKey(x => x.BlogId)
                .OnDelete(DeleteBehavior.NoAction);

            // Indexes
            builder.HasIndex(x => x.BlogId);
        }
    }
}
