using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouyarRealState.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migSeedMiddleEastLanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategories_Languages_LanguageId",
                schema: "hou",
                table: "BlogCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Languages_LanguageId",
                schema: "hou",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Footers_Languages_LanguageId",
                schema: "hou",
                table: "Footers");

            migrationBuilder.DropForeignKey(
                name: "FK_HomePages_Languages_LanguageId",
                schema: "hou",
                table: "HomePages");

            migrationBuilder.InsertData(
                schema: "hou",
                table: "Languages",
                columns: new[] { "Id", "Code", "Culture", "Flag", "IsActive", "IsDefault", "IsDelete", "IsRtl", "Name", "NativeName" },
                values: new object[] { new Guid("3f2504e0-4f89-41d3-9a0c-0305e82c3301"), "fa", "fa-IR", "fa.png", true, true, false, true, "Persian", "فارسی" });

            migrationBuilder.InsertData(
                schema: "hou",
                table: "Languages",
                columns: new[] { "Id", "Code", "Culture", "Flag", "IsActive", "IsDelete", "Name", "NativeName" },
                values: new object[] { new Guid("4f2504e0-4f89-41d3-9a0c-0305e82c3302"), "en", "en-US", "en.png", true, false, "English", "English" });

            migrationBuilder.InsertData(
                schema: "hou",
                table: "Languages",
                columns: new[] { "Id", "Code", "Culture", "Flag", "IsActive", "IsDelete", "IsRtl", "Name", "NativeName" },
                values: new object[] { new Guid("5f2504e0-4f89-41d3-9a0c-0305e82c3303"), "ar", "ar-SA", "ar.png", true, false, true, "Arabic", "العربية" });

            migrationBuilder.InsertData(
                schema: "hou",
                table: "Languages",
                columns: new[] { "Id", "Code", "Culture", "Flag", "IsActive", "IsDelete", "Name", "NativeName" },
                values: new object[] { new Guid("6f2504e0-4f89-41d3-9a0c-0305e82c3304"), "tr", "tr-TR", "tr.png", true, false, "Turkish", "Türkçe" });

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategories_Languages_LanguageId",
                schema: "hou",
                table: "BlogCategories",
                column: "LanguageId",
                principalSchema: "hou",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Languages_LanguageId",
                schema: "hou",
                table: "Blogs",
                column: "LanguageId",
                principalSchema: "hou",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Footers_Languages_LanguageId",
                schema: "hou",
                table: "Footers",
                column: "LanguageId",
                principalSchema: "hou",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HomePages_Languages_LanguageId",
                schema: "hou",
                table: "HomePages",
                column: "LanguageId",
                principalSchema: "hou",
                principalTable: "Languages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategories_Languages_LanguageId",
                schema: "hou",
                table: "BlogCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Languages_LanguageId",
                schema: "hou",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Footers_Languages_LanguageId",
                schema: "hou",
                table: "Footers");

            migrationBuilder.DropForeignKey(
                name: "FK_HomePages_Languages_LanguageId",
                schema: "hou",
                table: "HomePages");

            migrationBuilder.DeleteData(
                schema: "hou",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("3f2504e0-4f89-41d3-9a0c-0305e82c3301"));

            migrationBuilder.DeleteData(
                schema: "hou",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("4f2504e0-4f89-41d3-9a0c-0305e82c3302"));

            migrationBuilder.DeleteData(
                schema: "hou",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("5f2504e0-4f89-41d3-9a0c-0305e82c3303"));

            migrationBuilder.DeleteData(
                schema: "hou",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("6f2504e0-4f89-41d3-9a0c-0305e82c3304"));

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategories_Languages_LanguageId",
                schema: "hou",
                table: "BlogCategories",
                column: "LanguageId",
                principalSchema: "hou",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Languages_LanguageId",
                schema: "hou",
                table: "Blogs",
                column: "LanguageId",
                principalSchema: "hou",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Footers_Languages_LanguageId",
                schema: "hou",
                table: "Footers",
                column: "LanguageId",
                principalSchema: "hou",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomePages_Languages_LanguageId",
                schema: "hou",
                table: "HomePages",
                column: "LanguageId",
                principalSchema: "hou",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
