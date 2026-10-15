using System;
using System.Collections.Generic;
using System.Text;
using HouyarRealState.Domain.Entities.Article;
using HouyarRealState.Domain.Entities.Marketing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Marketing
{
    public class NewsletterSubscriberConfiguration : IEntityTypeConfiguration<NewsletterSubscriber>
    {
        public void Configure(EntityTypeBuilder<NewsletterSubscriber> builder)
        {
            // Table
            builder.ToTable("NewsletterSubscribers");

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(254);

            builder.Property(x => x.SubscribedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(x => x.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            // Indexes
            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.HasIndex(x => x.IsActive);
        }
    }
}
