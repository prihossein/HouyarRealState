using HouyarRealState.Domain.Entities.Settings.Footer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Settings
{
    public class FooterConfiguration : IEntityTypeConfiguration<Footer>
    {
        public void Configure(EntityTypeBuilder<Footer> builder)
        {
            // Table
            builder.ToTable("Footers");

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.LanguageId)
                .IsRequired();

            builder.Property(x => x.ShortDescription)
                .HasMaxLength(1000)
                .IsRequired(false);

            builder.Property(x => x.Address)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(x => x.Mobile)
                .HasMaxLength(20)
                .IsRequired(false);

            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(20)
                .IsRequired(false);

            builder.Property(x => x.Email)
                .HasMaxLength(254)
                .IsRequired(false);

            // Relationship: Footer -> Language
            builder.HasOne(x => x.Language)
                .WithMany()
                .HasForeignKey(x => x.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relationship: Footer -> FooterMenus
            builder.HasMany(x => x.FooterMenus)
                .WithOne(x => x.Footer)
                .HasForeignKey(x => x.FooterId)
                .OnDelete(DeleteBehavior.Cascade);

            // Indexes
            builder.HasIndex(x => x.LanguageId)
                .IsUnique();
        }
    }
}
