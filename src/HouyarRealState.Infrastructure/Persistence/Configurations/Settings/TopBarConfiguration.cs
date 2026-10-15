using HouyarRealState.Domain.Entities.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Settings
{
    public class TopBarConfiguration : IEntityTypeConfiguration<TopBar>
    {
        public void Configure(EntityTypeBuilder<TopBar> builder)
        {
            builder.ToTable("TopBars");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.LanguageId)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(254);

            builder.Property(x => x.Address)
                .HasMaxLength(500);

            builder.HasOne(x => x.Language)
                .WithMany(x => x.TopBars)
                .HasForeignKey(x => x.LanguageId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(x => x.LanguageId)
                .IsUnique();
        }
    }
}
