using HouyarRealState.Domain.Entities.Pages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Pages
{
    public class HomePageConfiguration : IEntityTypeConfiguration<HomePage>
    {
        public void Configure(EntityTypeBuilder<HomePage> builder)
        {
            // Table
            builder.ToTable("HomePages");

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.LanguageId)
                .IsRequired();

            builder.Property(x => x.SeoTitle)
                .HasMaxLength(300)
                .IsRequired(false);

            builder.Property(x => x.MetaDescription)
                .HasMaxLength(500)
                .IsRequired(false);

            // Relationship: HomePage -> Language
            builder.HasOne(x => x.Language)
                .WithMany()
                .HasForeignKey(x => x.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            // Indexes
            builder.HasIndex(x => x.LanguageId)
                .IsUnique();
        }
    }
}
