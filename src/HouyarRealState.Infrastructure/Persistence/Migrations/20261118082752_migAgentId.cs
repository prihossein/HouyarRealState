using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouyarRealState.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migAgentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_AspNetUsers_UserId",
                schema: "hou",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "hou",
                table: "Properties",
                newName: "AgentId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_UserId_IsDelete",
                schema: "hou",
                table: "Properties",
                newName: "IX_Properties_AgentId_IsDelete");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_UserId",
                schema: "hou",
                table: "Properties",
                newName: "IX_Properties_AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_AspNetUsers_AgentId",
                schema: "hou",
                table: "Properties",
                column: "AgentId",
                principalSchema: "hou",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_AspNetUsers_AgentId",
                schema: "hou",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "AgentId",
                schema: "hou",
                table: "Properties",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_AgentId_IsDelete",
                schema: "hou",
                table: "Properties",
                newName: "IX_Properties_UserId_IsDelete");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_AgentId",
                schema: "hou",
                table: "Properties",
                newName: "IX_Properties_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_AspNetUsers_UserId",
                schema: "hou",
                table: "Properties",
                column: "UserId",
                principalSchema: "hou",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
