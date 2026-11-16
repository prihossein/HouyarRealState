using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HouyarRealState.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migSeedFooter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "hou",
                table: "Footers",
                columns: new[] { "Id", "Address", "Email", "IsDelete", "LanguageId", "Mobile", "PhoneNumber", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("3f2504e0-4f89-41d3-9a0c-0305e82c0001"), "ایران، فارس، شیراز، دینکان، مشاور املاک هویار", "houyarrealstate@gmail.com", false, new Guid("3f2504e0-4f89-41d3-9a0c-0305e82c3301"), "09171022924", "09171022924", "مشاور املاک هویار، همراه شما در مسیر خرید، فروش و اجاره ملک. ما با هدف ارائه خدمات حرفه‌ای در حوزه املاک، تلاش می‌کنیم تجربه‌ای مطمئن و آسان برای انتخاب خانه، آپارتمان و سرمایه‌گذاری ملکی فراهم کنیم. هویار با ارائه اطلاعات دقیق و راهنمایی تخصصی، در تمام مراحل انتخاب و انجام معاملات ملکی در کنار شماست." },
                    { new Guid("4f2504e0-4f89-41d3-9a0c-0305e82c0002"), "Dinkān, Shiraz, Fars, Iran — Houyar Real Estate", "houyarrealstate@gmail.com", false, new Guid("4f2504e0-4f89-41d3-9a0c-0305e82c3302"), "09171022924", "09171022924", "Houyar Real Estate is your trusted partner for buying, selling, and renting properties. We strive to provide professional real estate services and make finding a home, apartment, or property investment an easy and reliable experience. With accurate information and expert guidance, we support you throughout every stage of your property search and real estate transactions." },
                    { new Guid("5f2504e0-4f89-41d3-9a0c-0305e82c0003"), "دينكان، شيراز، محافظة فارس، إيران — وكالة هويار العقارية", "houyarrealstate@gmail.com", false, new Guid("5f2504e0-4f89-41d3-9a0c-0305e82c3303"), "09171022924", "09171022924", "وكالة هويار العقارية شريككم الموثوق في شراء العقارات وبيعها وتأجيرها. نسعى إلى تقديم خدمات عقارية احترافية تساعدكم على العثور على المنزل أو الشقة المناسبة والاستثمار العقاري بكل سهولة واطمئنان. ومن خلال توفير معلومات دقيقة وإرشادات متخصصة، نرافقكم في جميع مراحل البحث عن العقار وإتمام المعاملات العقارية." },
                    { new Guid("6f2504e0-4f89-41d3-9a0c-0305e82c0004"), "Dinkan, Şiraz, Fars Eyaleti, İran — Houyar Gayrimenkul", "houyarrealstate@gmail.com", false, new Guid("6f2504e0-4f89-41d3-9a0c-0305e82c3304"), "09171022924", "09171022924", "Houyar Gayrimenkul, gayrimenkul alım, satım ve kiralama süreçlerinde güvenilir çözüm ortağınızdır. Ev, daire veya gayrimenkul yatırımı arayışınızı kolaylaştırmak için profesyonel hizmetler sunmayı amaçlıyoruz. Doğru bilgiler ve uzman rehberliğiyle gayrimenkul arayışınızın ve işlemlerinizin her aşamasında yanınızdayız." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "hou",
                table: "Footers",
                keyColumn: "Id",
                keyValue: new Guid("3f2504e0-4f89-41d3-9a0c-0305e82c0001"));

            migrationBuilder.DeleteData(
                schema: "hou",
                table: "Footers",
                keyColumn: "Id",
                keyValue: new Guid("4f2504e0-4f89-41d3-9a0c-0305e82c0002"));

            migrationBuilder.DeleteData(
                schema: "hou",
                table: "Footers",
                keyColumn: "Id",
                keyValue: new Guid("5f2504e0-4f89-41d3-9a0c-0305e82c0003"));

            migrationBuilder.DeleteData(
                schema: "hou",
                table: "Footers",
                keyColumn: "Id",
                keyValue: new Guid("6f2504e0-4f89-41d3-9a0c-0305e82c0004"));
        }
    }
}
