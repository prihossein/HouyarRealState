using HouyarRealState.Domain.Entities.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Settings
{
    public class SocialNetworkConfiguration : IEntityTypeConfiguration<SocialNetwork>
    {
        public void Configure(EntityTypeBuilder<SocialNetwork> builder)
        {
            builder.ToTable("SocialNetworks");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Instagram)
                .HasMaxLength(300);

            builder.Property(x => x.Telegram)
                .HasMaxLength(300);

            builder.Property(x => x.Facebook)
                .HasMaxLength(300);

            builder.Property(x => x.LinkedIn)
                .HasMaxLength(300);

            builder.Property(x => x.X)
                .HasMaxLength(300);

            builder.Property(x => x.Aparat)
                .HasMaxLength(300);

            builder.Property(x => x.YouTube)
                .HasMaxLength(300);

            builder.Property(x => x.Bale)
                .HasMaxLength(300);

            builder.Property(x => x.Eitaa)
                .HasMaxLength(300);

            builder.Property(x => x.Rubika)
                .HasMaxLength(300);
        }
    }
}
