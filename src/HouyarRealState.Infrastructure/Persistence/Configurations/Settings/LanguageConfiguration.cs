using HouyarRealState.Domain.Entities.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Settings
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            // Table
            builder.ToTable("Languages");

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(x => x.Culture)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(x => x.NativeName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Flag)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(x => x.IsRtl)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.IsDefault)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            // Indexes
            builder.HasIndex(x => x.Code)
                .IsUnique();

            builder.HasIndex(x => x.Culture)
                .IsUnique();

            builder.HasIndex(x => x.IsActive);

            // Relationships

            // Language -> TopBars
            builder.HasMany(x => x.TopBars)
                .WithOne(x => x.Language)
                .HasForeignKey(x => x.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            // Language -> Blogs
            builder.HasMany(x => x.Blogs)
                .WithOne(x => x.Language)
                .HasForeignKey(x => x.LanguageId)
                .OnDelete(DeleteBehavior.NoAction);

            // Language -> BlogCategories
            builder.HasMany(x => x.BlogCategories)
                .WithOne(x => x.Language)
                .HasForeignKey(x => x.LanguageId)
                .OnDelete(DeleteBehavior.NoAction);

            // Language -> HomePages
            builder.HasMany(x => x.HomePages)
                .WithOne(x => x.Language)
                .HasForeignKey(x => x.LanguageId)
                .OnDelete(DeleteBehavior.NoAction);

            // Language -> Footers
            builder.HasMany(x => x.Footers)
                .WithOne(x => x.Language)
                .HasForeignKey(x => x.LanguageId)
                .OnDelete(DeleteBehavior.NoAction);

            // Only one default language
            builder.HasIndex(x => x.IsDefault)
                .IsUnique()
                .HasFilter("[IsDefault] = 1");

            #region Seed Data
            builder.HasData(
                new Language
                {
                    Id = Guid.Parse("3F2504E0-4F89-41D3-9A0C-0305E82C3301"),
                    Code = "fa",
                    Culture = "fa-IR",
                    IsRtl = true,
                    Name = "Persian",
                    NativeName = "فارسی",
                    IsDefault = true,
                    IsActive = true,
                    Flag = "fa.png",
                },
                new Language
                {
                    Id = Guid.Parse("4F2504E0-4F89-41D3-9A0C-0305E82C3302"),
                    Code = "en",
                    Culture = "en-US",
                    IsRtl = false,
                    Name = "English",
                    NativeName = "English",
                    IsDefault = false,
                    IsActive = true,
                    Flag = "en.png",
                },
                new Language
                {
                    Id = Guid.Parse("5F2504E0-4F89-41D3-9A0C-0305E82C3303"),
                    Code = "ar",
                    Culture = "ar-SA",
                    IsRtl = true,
                    Name = "Arabic",
                    NativeName = "العربية",
                    IsDefault = false,
                    IsActive = true,
                    Flag = "ar.png",
                },
                new Language
                {
                    Id = Guid.Parse("6F2504E0-4F89-41D3-9A0C-0305E82C3304"),
                    Code = "tr",
                    Culture = "tr-TR",
                    IsRtl = false,
                    Name = "Turkish",
                    NativeName = "Türkçe",
                    IsDefault = false,
                    IsActive = true,
                    Flag = "tr.png",
                }
            );
            #endregion
        }
    }
}
