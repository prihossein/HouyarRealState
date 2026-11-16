using HouyarRealState.Application.Wrappers;
using HouyarRealState.Domain.Entities.Settings;
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

            #region Seed Data
            builder.HasData(
                new Footer
                {
                    Id = Guid.Parse("3F2504E0-4F89-41D3-9A0C-0305E82C0001"),
                    LanguageId = Guid.Parse(LanguageNames.Persian),
                    PhoneNumber = "09171022924",
                    Mobile = "09171022924",
                    Email = "houyarrealstate@gmail.com",
                    ShortDescription = "مشاور املاک هویار، همراه شما در مسیر خرید، فروش و اجاره ملک. ما با هدف ارائه خدمات حرفه‌ای در حوزه املاک، تلاش می‌کنیم تجربه‌ای مطمئن و آسان برای انتخاب خانه، آپارتمان و سرمایه‌گذاری ملکی فراهم کنیم. هویار با ارائه اطلاعات دقیق و راهنمایی تخصصی، در تمام مراحل انتخاب و انجام معاملات ملکی در کنار شماست.",
                    Address = "ایران، فارس، شیراز، دینکان، مشاور املاک هویار"
                },
                new Footer
                {
                    Id = Guid.Parse("4F2504E0-4F89-41D3-9A0C-0305E82C0002"),
                    LanguageId = Guid.Parse(LanguageNames.English),
                    PhoneNumber = "09171022924",
                    Mobile = "09171022924",
                    Email = "houyarrealstate@gmail.com",
                    ShortDescription = "Houyar Real Estate is your trusted partner for buying, selling, and renting properties. We strive to provide professional real estate services and make finding a home, apartment, or property investment an easy and reliable experience. With accurate information and expert guidance, we support you throughout every stage of your property search and real estate transactions.",
                    Address = "Dinkān, Shiraz, Fars, Iran — Houyar Real Estate"
                },
                new Footer
                {
                    Id = Guid.Parse("5F2504E0-4F89-41D3-9A0C-0305E82C0003"),
                    LanguageId = Guid.Parse(LanguageNames.Arabic),
                    PhoneNumber = "09171022924",
                    Mobile = "09171022924",
                    Email = "houyarrealstate@gmail.com",
                    ShortDescription = "وكالة هويار العقارية شريككم الموثوق في شراء العقارات وبيعها وتأجيرها. نسعى إلى تقديم خدمات عقارية احترافية تساعدكم على العثور على المنزل أو الشقة المناسبة والاستثمار العقاري بكل سهولة واطمئنان. ومن خلال توفير معلومات دقيقة وإرشادات متخصصة، نرافقكم في جميع مراحل البحث عن العقار وإتمام المعاملات العقارية.",
                    Address = "دينكان، شيراز، محافظة فارس، إيران — وكالة هويار العقارية"
                },
                new Footer
                {
                    Id = Guid.Parse("6F2504E0-4F89-41D3-9A0C-0305E82C0004"),
                    LanguageId = Guid.Parse(LanguageNames.Turkish),
                    PhoneNumber = "09171022924",
                    Mobile = "09171022924",
                    Email = "houyarrealstate@gmail.com",
                    ShortDescription = "Houyar Gayrimenkul, gayrimenkul alım, satım ve kiralama süreçlerinde güvenilir çözüm ortağınızdır. Ev, daire veya gayrimenkul yatırımı arayışınızı kolaylaştırmak için profesyonel hizmetler sunmayı amaçlıyoruz. Doğru bilgiler ve uzman rehberliğiyle gayrimenkul arayışınızın ve işlemlerinizin her aşamasında yanınızdayız.",
                    Address = "Dinkan, Şiraz, Fars Eyaleti, İran — Houyar Gayrimenkul"
                }
            );
            #endregion
        }
    }
}
