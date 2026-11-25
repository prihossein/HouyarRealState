using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouyarRealState.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migChatId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Properties_IsDelete",
                schema: "hou",
                table: "Properties");

            migrationBuilder.AddColumn<string>(
                name: "BaleChatId",
                schema: "hou",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaleChatId",
                schema: "hou",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_IsDelete",
                schema: "hou",
                table: "Properties",
                column: "IsDelete");
        }
    }
}
