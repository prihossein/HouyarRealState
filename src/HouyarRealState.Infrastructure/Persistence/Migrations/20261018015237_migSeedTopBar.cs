using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HouyarRealState.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migSeedTopBar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "hou",
                table: "TopBars",
                columns: new[] { "Id", "Address", "Email", "IsDelete", "LanguageId" },
                values: new object[,]
                {
                    { new Guid("3f2504e0-4f89-41d3-9a0c-0305e82c3201"), "ایران، شیراز، خیابان شهید دینکانی، مشاور املاک هویار", "houyar@ifo.com", false, new Guid("3f2504e0-4f89-41d3-9a0c-0305e82c3301") },
                    { new Guid("4f2504e0-4f89-41d3-9a0c-0305e82c3202"), "Houyar Real Estate Agency, Shahid Dinkani Street, Shiraz, Iran", "houyar@ifo.com", false, new Guid("4f2504e0-4f89-41d3-9a0c-0305e82c3302") },
                    { new Guid("5f2504e0-4f89-41d3-9a0c-0305e82c3203"), "وكالة هويار للعقارات، شارع الشهيد دينكاني، شيراز، إيران", "houyar@ifo.com", false, new Guid("5f2504e0-4f89-41d3-9a0c-0305e82c3303") },
                    { new Guid("6f2504e0-4f89-41d3-9a0c-0305e82c3204"), "Houyar Emlak Danışmanlığı, Shahid Dinkani Caddesi, Şiraz, İran", "houyar@ifo.com", false, new Guid("6f2504e0-4f89-41d3-9a0c-0305e82c3304") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "hou",
                table: "TopBars",
                keyColumn: "Id",
                keyValue: new Guid("3f2504e0-4f89-41d3-9a0c-0305e82c3201"));

            migrationBuilder.DeleteData(
                schema: "hou",
                table: "TopBars",
                keyColumn: "Id",
                keyValue: new Guid("4f2504e0-4f89-41d3-9a0c-0305e82c3202"));

            migrationBuilder.DeleteData(
                schema: "hou",
                table: "TopBars",
                keyColumn: "Id",
                keyValue: new Guid("5f2504e0-4f89-41d3-9a0c-0305e82c3203"));

            migrationBuilder.DeleteData(
                schema: "hou",
                table: "TopBars",
                keyColumn: "Id",
                keyValue: new Guid("6f2504e0-4f89-41d3-9a0c-0305e82c3204"));
        }
    }
}
