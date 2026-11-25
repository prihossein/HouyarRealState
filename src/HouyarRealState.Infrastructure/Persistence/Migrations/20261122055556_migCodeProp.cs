using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouyarRealState.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migCodeProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                schema: "hou",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                schema: "hou",
                table: "Properties");
        }
    }
}
