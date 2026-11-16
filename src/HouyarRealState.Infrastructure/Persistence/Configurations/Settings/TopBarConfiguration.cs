using HouyarRealState.Application.Wrappers;
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


            #region Seed Data
            builder.HasData(
                new TopBar
                {
                    Id = Guid.Parse("3F2504E0-4F89-41D3-9A0C-0305E82C3201"),
                    LanguageId = Guid.Parse(LanguageNames.Persian),
                    Email = "houyar@ifo.com",
                    Address = "ایران، شیراز، خیابان شهید دینکانی، مشاور املاک هویار",
                },
                new TopBar
                {
                    Id = Guid.Parse("4F2504E0-4F89-41D3-9A0C-0305E82C3202"),
                    LanguageId = Guid.Parse(LanguageNames.English),
                    Email = "houyar@ifo.com",
                    Address = "Houyar Real Estate Agency, Shahid Dinkani Street, Shiraz, Iran",
                },
                new TopBar
                {
                    Id = Guid.Parse("5F2504E0-4F89-41D3-9A0C-0305E82C3203"),
                    LanguageId = Guid.Parse(LanguageNames.Arabic),
                    Email = "houyar@ifo.com",
                    Address = "وكالة هويار للعقارات، شارع الشهيد دينكاني، شيراز، إيران",
                },
                new TopBar
                {
                    Id = Guid.Parse("6F2504E0-4F89-41D3-9A0C-0305E82C3204"),
                    LanguageId = Guid.Parse(LanguageNames.Turkish),
                    Email = "houyar@ifo.com",
                    Address = "Houyar Emlak Danışmanlığı, Shahid Dinkani Caddesi, Şiraz, İran",
                }
            );
            #endregion
        }
    }
}
