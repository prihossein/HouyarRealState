using HouyarRealState.Domain.Entities.Settings.Footer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Settings
{
    public class FooterMenuConfiguration : IEntityTypeConfiguration<FooterMenu>
    {
        public void Configure(EntityTypeBuilder<FooterMenu> builder)
        {
            // Table
            builder.ToTable("FooterMenus");

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.FooterId)
                .IsRequired();

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

            // Relationship: FooterMenu -> Footer
            builder.HasOne(x => x.Footer)
                .WithMany(x => x.FooterMenus)
                .HasForeignKey(x => x.FooterId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relationship: FooterMenu -> FooterMenuItems
            builder.HasMany(x => x.FooterMenuItems)
                .WithOne(x => x.FooterMenu)
                .HasForeignKey(x => x.FooterMenuId)
                .OnDelete(DeleteBehavior.NoAction);

            // Indexes
            builder.HasIndex(x => x.FooterId);
        }
    }
}
