using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouyarRealState.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migInitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "hou");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsConfirmedMobile = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsBan = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    OTPCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    OTPCodeExpireDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastOTPSentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyFeatures",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyRequestTypes",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRequestTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyStatuses",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "hou",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "hou",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "hou",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "hou",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "hou",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "hou",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "hou",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "hou",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "hou",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyRequestTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenovationCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDraft = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MinPricePerMeter = table.Column<double>(type: "float", nullable: true),
                    MaxPricePerMeter = table.Column<double>(type: "float", nullable: true),
                    MinTotalPrice = table.Column<double>(type: "float", nullable: true),
                    MaxTotalPrice = table.Column<double>(type: "float", nullable: true),
                    Latitude = table.Column<double>(type: "float(9)", precision: 9, scale: 6, nullable: true),
                    Longitude = table.Column<double>(type: "float(9)", precision: 9, scale: 6, nullable: true),
                    Area = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    BuiltArea = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    TransactionTypeId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "hou",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Properties_PropertyRequestTypes_PropertyRequestTypeId",
                        column: x => x.PropertyRequestTypeId,
                        principalSchema: "hou",
                        principalTable: "PropertyRequestTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Properties_PropertyStatuses_PropertyStatusId",
                        column: x => x.PropertyStatusId,
                        principalSchema: "hou",
                        principalTable: "PropertyStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Properties_PropertyTypes_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalSchema: "hou",
                        principalTable: "PropertyTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Properties_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalSchema: "hou",
                        principalTable: "TransactionTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Properties_TransactionTypes_TransactionTypeId1",
                        column: x => x.TransactionTypeId1,
                        principalSchema: "hou",
                        principalTable: "TransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyInFeatures",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyFeatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyInFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyInFeatures_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalSchema: "hou",
                        principalTable: "Properties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropertyInFeatures_PropertyFeatures_PropertyFeatureId",
                        column: x => x.PropertyFeatureId,
                        principalSchema: "hou",
                        principalTable: "PropertyFeatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "hou",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "hou",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "hou",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "hou",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "hou",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "hou",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Code",
                schema: "hou",
                table: "AspNetUsers",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Mobile",
                schema: "hou",
                table: "AspNetUsers",
                column: "Mobile");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "hou",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CreateDate",
                schema: "hou",
                table: "Properties",
                column: "CreateDate");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_IsDelete",
                schema: "hou",
                table: "Properties",
                column: "IsDelete");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyRequestTypeId",
                schema: "hou",
                table: "Properties",
                column: "PropertyRequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyRequestTypeId_PropertyTypeId_TransactionTypeId_IsDelete",
                schema: "hou",
                table: "Properties",
                columns: new[] { "PropertyRequestTypeId", "PropertyTypeId", "TransactionTypeId", "IsDelete" });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyStatusId_IsDelete_CreateDate",
                schema: "hou",
                table: "Properties",
                columns: new[] { "PropertyStatusId", "IsDelete", "CreateDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyTypeId",
                schema: "hou",
                table: "Properties",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_TransactionTypeId",
                schema: "hou",
                table: "Properties",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_TransactionTypeId1",
                schema: "hou",
                table: "Properties",
                column: "TransactionTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UserId",
                schema: "hou",
                table: "Properties",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UserId_IsDelete",
                schema: "hou",
                table: "Properties",
                columns: new[] { "UserId", "IsDelete" });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyFeatures_IsDelete",
                schema: "hou",
                table: "PropertyFeatures",
                column: "IsDelete");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyFeatures_Title",
                schema: "hou",
                table: "PropertyFeatures",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyInFeatures_IsDelete",
                schema: "hou",
                table: "PropertyInFeatures",
                column: "IsDelete");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyInFeatures_PropertyFeatureId",
                schema: "hou",
                table: "PropertyInFeatures",
                column: "PropertyFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyInFeatures_PropertyId",
                schema: "hou",
                table: "PropertyInFeatures",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyInFeatures_PropertyId_PropertyFeatureId",
                schema: "hou",
                table: "PropertyInFeatures",
                columns: new[] { "PropertyId", "PropertyFeatureId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRequestTypes_Code",
                schema: "hou",
                table: "PropertyRequestTypes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStatuses_IsDelete",
                schema: "hou",
                table: "PropertyStatuses",
                column: "IsDelete");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStatuses_IsDelete_Title",
                schema: "hou",
                table: "PropertyStatuses",
                columns: new[] { "IsDelete", "Title" });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStatuses_Title",
                schema: "hou",
                table: "PropertyStatuses",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTypes_IsDelete",
                schema: "hou",
                table: "PropertyTypes",
                column: "IsDelete");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTypes_IsDelete_Title",
                schema: "hou",
                table: "PropertyTypes",
                columns: new[] { "IsDelete", "Title" });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTypes_Title",
                schema: "hou",
                table: "PropertyTypes",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTypes_IsDelete",
                schema: "hou",
                table: "TransactionTypes",
                column: "IsDelete");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTypes_IsDelete_Title",
                schema: "hou",
                table: "TransactionTypes",
                columns: new[] { "IsDelete", "Title" });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTypes_Title",
                schema: "hou",
                table: "TransactionTypes",
                column: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "PropertyInFeatures",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "Properties",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "PropertyFeatures",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "PropertyRequestTypes",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "PropertyStatuses",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "PropertyTypes",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "TransactionTypes",
                schema: "hou");
        }
    }
}
