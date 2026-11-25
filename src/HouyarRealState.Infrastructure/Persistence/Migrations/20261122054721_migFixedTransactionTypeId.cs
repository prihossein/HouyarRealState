using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouyarRealState.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migFixedTransactionTypeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_TransactionTypes_TransactionTypeId1",
                schema: "hou",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_TransactionTypeId1",
                schema: "hou",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "TransactionTypeId1",
                schema: "hou",
                table: "Properties");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TransactionTypeId1",
                schema: "hou",
                table: "Properties",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Properties_TransactionTypeId1",
                schema: "hou",
                table: "Properties",
                column: "TransactionTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_TransactionTypes_TransactionTypeId1",
                schema: "hou",
                table: "Properties",
                column: "TransactionTypeId1",
                principalSchema: "hou",
                principalTable: "TransactionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
