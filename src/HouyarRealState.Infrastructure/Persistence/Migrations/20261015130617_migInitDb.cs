using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouyarRealState.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migInitDb : Migration
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
                name: "BlogTags",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TagUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Culture = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NativeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Flag = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsRtl = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsletterSubscribers",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    SubscribedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsletterSubscribers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialNetworks",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Instagram = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Telegram = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    X = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Aparat = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    YouTube = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Bale = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Eitaa = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Rubika = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialNetworks", x => x.Id);
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
                name: "BlogCategories",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    TitleCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ThumbnailImageName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    SmallThumbnailImageName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AltThumbnailImage = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IsUncategorized = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SEOTitle = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogCategories_BlogCategories_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "hou",
                        principalTable: "BlogCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogCategories_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "hou",
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AspNetUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 450, nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SEOTitle = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CanonicalLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsNoIndex = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsEnabledComment = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThumbnailImageName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    SmallThumbnailImageName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AltThumbnail = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDraft = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalSchema: "hou",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Blogs_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "hou",
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Footers",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Footers_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "hou",
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HomePages",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomePages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "hou",
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PropertyTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Draft"),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsHighlighted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ViewCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Area = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BuiltArea = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    LandArea = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    UsefulArea = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    Bedrooms = table.Column<int>(type: "int", nullable: true),
                    Bathrooms = table.Column<int>(type: "int", nullable: true),
                    Showers = table.Column<int>(type: "int", nullable: true),
                    LivingRooms = table.Column<int>(type: "int", nullable: true),
                    Kitchens = table.Column<int>(type: "int", nullable: true),
                    Floors = table.Column<int>(type: "int", nullable: true),
                    FloorNumber = table.Column<int>(type: "int", nullable: true),
                    UnitsCount = table.Column<int>(type: "int", nullable: true),
                    UnitsPerFloor = table.Column<int>(type: "int", nullable: true),
                    CeilingHeight = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    ConstructionYear = table.Column<int>(type: "int", nullable: true),
                    RenovationYear = table.Column<int>(type: "int", nullable: true),
                    BalconiesCount = table.Column<int>(type: "int", nullable: true),
                    TerracesCount = table.Column<int>(type: "int", nullable: true),
                    StorageCount = table.Column<int>(type: "int", nullable: true),
                    ParkingCount = table.Column<int>(type: "int", nullable: true),
                    ElevatorsCount = table.Column<int>(type: "int", nullable: true),
                    ElevatorCapacity = table.Column<int>(type: "int", nullable: true),
                    EntrancesCount = table.Column<int>(type: "int", nullable: true),
                    LightSidesCount = table.Column<int>(type: "int", nullable: true),
                    IndependentUnitsCount = table.Column<int>(type: "int", nullable: true),
                    IsNewlyBuilt = table.Column<bool>(type: "bit", nullable: false),
                    IsUnused = table.Column<bool>(type: "bit", nullable: false),
                    IsRenovated = table.Column<bool>(type: "bit", nullable: false),
                    IsUnderConstruction = table.Column<bool>(type: "bit", nullable: false),
                    IsReadyToMove = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    PricePerSquareMeter = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    Deposit = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    MonthlyRent = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    DownPayment = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    MonthlyInstallment = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    InstallmentsCount = table.Column<int>(type: "int", nullable: true),
                    InstallmentAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    MonthlyBuildingCharge = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    MonthlyMaintenanceCost = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    MonthlyUtilitiesCost = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    Commission = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    IsPriceNegotiable = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsInstallmentSale = table.Column<bool>(type: "bit", nullable: false),
                    IsExchangeable = table.Column<bool>(type: "bit", nullable: false),
                    IsBarterPossible = table.Column<bool>(type: "bit", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValue: "IRR"),
                    PaymentTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    District = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Neighborhood = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SideStreet = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Alley = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    پلاک = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressFloor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: true),
                    Direction = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WindowDirection = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    HasMainStreetAccess = table.Column<bool>(type: "bit", nullable: false),
                    HasPublicTransportAccess = table.Column<bool>(type: "bit", nullable: false),
                    HasMetroAccess = table.Column<bool>(type: "bit", nullable: false),
                    HasShoppingCenterAccess = table.Column<bool>(type: "bit", nullable: false),
                    HasMedicalCenterAccess = table.Column<bool>(type: "bit", nullable: false),
                    HasSchoolAccess = table.Column<bool>(type: "bit", nullable: false),
                    LocationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasParking = table.Column<bool>(type: "bit", nullable: false),
                    HasCoveredParking = table.Column<bool>(type: "bit", nullable: false),
                    HasPrivateParking = table.Column<bool>(type: "bit", nullable: false),
                    HasGuestParking = table.Column<bool>(type: "bit", nullable: false),
                    HasElevator = table.Column<bool>(type: "bit", nullable: false),
                    HasStorage = table.Column<bool>(type: "bit", nullable: false),
                    HasBalcony = table.Column<bool>(type: "bit", nullable: false),
                    HasTerrace = table.Column<bool>(type: "bit", nullable: false),
                    HasYard = table.Column<bool>(type: "bit", nullable: false),
                    HasPrivateYard = table.Column<bool>(type: "bit", nullable: false),
                    HasGarden = table.Column<bool>(type: "bit", nullable: false),
                    HasRoofGarden = table.Column<bool>(type: "bit", nullable: false),
                    HasSwimmingPool = table.Column<bool>(type: "bit", nullable: false),
                    HasIndoorPool = table.Column<bool>(type: "bit", nullable: false),
                    HasOutdoorPool = table.Column<bool>(type: "bit", nullable: false),
                    HasSauna = table.Column<bool>(type: "bit", nullable: false),
                    HasJacuzzi = table.Column<bool>(type: "bit", nullable: false),
                    HasGym = table.Column<bool>(type: "bit", nullable: false),
                    HasMeetingRoom = table.Column<bool>(type: "bit", nullable: false),
                    HasPlayroom = table.Column<bool>(type: "bit", nullable: false),
                    HasSharedGreenSpace = table.Column<bool>(type: "bit", nullable: false),
                    HasLobby = table.Column<bool>(type: "bit", nullable: false),
                    HasSecurityGuard = table.Column<bool>(type: "bit", nullable: false),
                    HasCaretaker = table.Column<bool>(type: "bit", nullable: false),
                    HasCCTV = table.Column<bool>(type: "bit", nullable: false),
                    HasFireAlarm = table.Column<bool>(type: "bit", nullable: false),
                    HasFireSuppressionSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasSecurityDoor = table.Column<bool>(type: "bit", nullable: false),
                    HasVideoIntercom = table.Column<bool>(type: "bit", nullable: false),
                    HasSmartHome = table.Column<bool>(type: "bit", nullable: false),
                    HasHighSpeedInternet = table.Column<bool>(type: "bit", nullable: false),
                    HasCentralAntenna = table.Column<bool>(type: "bit", nullable: false),
                    HasBackupPower = table.Column<bool>(type: "bit", nullable: false),
                    HasGenerator = table.Column<bool>(type: "bit", nullable: false),
                    HasWaterTank = table.Column<bool>(type: "bit", nullable: false),
                    HasWaterPump = table.Column<bool>(type: "bit", nullable: false),
                    HasWaterPurifier = table.Column<bool>(type: "bit", nullable: false),
                    HasWastewaterTreatment = table.Column<bool>(type: "bit", nullable: false),
                    HasDoubleGlazedWindows = table.Column<bool>(type: "bit", nullable: false),
                    HasSoundInsulation = table.Column<bool>(type: "bit", nullable: false),
                    HasThermalInsulation = table.Column<bool>(type: "bit", nullable: false),
                    HeatingSystem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CoolingSystem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HasAirConditioner = table.Column<bool>(type: "bit", nullable: false),
                    HasEvaporativeCooler = table.Column<bool>(type: "bit", nullable: false),
                    HasUnderfloorHeating = table.Column<bool>(type: "bit", nullable: false),
                    HasRadiator = table.Column<bool>(type: "bit", nullable: false),
                    HasFireplace = table.Column<bool>(type: "bit", nullable: false),
                    HasBoiler = table.Column<bool>(type: "bit", nullable: false),
                    HasCentralHeating = table.Column<bool>(type: "bit", nullable: false),
                    HasCentralAirConditioning = table.Column<bool>(type: "bit", nullable: false),
                    HasMechanicalVentilation = table.Column<bool>(type: "bit", nullable: false),
                    HotWaterSystem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FlooringType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WallCovering = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CeilingType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FacadeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CabinetType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CountertopType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WindowType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WindowFrameMaterial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InteriorDoorType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HasWardrobe = table.Column<bool>(type: "bit", nullable: false),
                    HasWalkInCloset = table.Column<bool>(type: "bit", nullable: false),
                    HasMasterBedroom = table.Column<bool>(type: "bit", nullable: false),
                    HasWesternToilet = table.Column<bool>(type: "bit", nullable: false),
                    HasIranianToilet = table.Column<bool>(type: "bit", nullable: false),
                    HasBathtub = table.Column<bool>(type: "bit", nullable: false),
                    HasShowerCabin = table.Column<bool>(type: "bit", nullable: false),
                    HasDecorativeLighting = table.Column<bool>(type: "bit", nullable: false),
                    HasFalseCeiling = table.Column<bool>(type: "bit", nullable: false),
                    HasCurtains = table.Column<bool>(type: "bit", nullable: false),
                    HasBuiltInFurniture = table.Column<bool>(type: "bit", nullable: false),
                    IsFurnished = table.Column<bool>(type: "bit", nullable: false),
                    IsSemiFurnished = table.Column<bool>(type: "bit", nullable: false),
                    InteriorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasStove = table.Column<bool>(type: "bit", nullable: false),
                    HasOven = table.Column<bool>(type: "bit", nullable: false),
                    HasMicrowave = table.Column<bool>(type: "bit", nullable: false),
                    HasRangeHood = table.Column<bool>(type: "bit", nullable: false),
                    HasDishwasher = table.Column<bool>(type: "bit", nullable: false),
                    HasWashingMachine = table.Column<bool>(type: "bit", nullable: false),
                    HasRefrigerator = table.Column<bool>(type: "bit", nullable: false),
                    HasEquippedKitchen = table.Column<bool>(type: "bit", nullable: false),
                    AppliancesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeedType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HasOfficialDeed = table.Column<bool>(type: "bit", nullable: false),
                    IsSixDang = table.Column<bool>(type: "bit", nullable: false),
                    IsDeedFree = table.Column<bool>(type: "bit", nullable: false),
                    HasCompletionCertificate = table.Column<bool>(type: "bit", nullable: false),
                    HasSubdivisionDocument = table.Column<bool>(type: "bit", nullable: false),
                    HasBuildingPermit = table.Column<bool>(type: "bit", nullable: false),
                    HasLandOwnershipDocument = table.Column<bool>(type: "bit", nullable: false),
                    HasLegalEncumbrance = table.Column<bool>(type: "bit", nullable: false),
                    IsMortgaged = table.Column<bool>(type: "bit", nullable: false),
                    IsSharedOwnership = table.Column<bool>(type: "bit", nullable: false),
                    IsInherited = table.Column<bool>(type: "bit", nullable: false),
                    HasCurrentTenant = table.Column<bool>(type: "bit", nullable: false),
                    CanTransferImmediately = table.Column<bool>(type: "bit", nullable: false),
                    LegalDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandUseType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsInsideUrbanBoundary = table.Column<bool>(type: "bit", nullable: false),
                    IsInUrbanTexture = table.Column<bool>(type: "bit", nullable: false),
                    IsInRuralTexture = table.Column<bool>(type: "bit", nullable: false),
                    HasStreetFrontage = table.Column<bool>(type: "bit", nullable: false),
                    FrontageLength = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    LandDepth = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    IsCornerLot = table.Column<bool>(type: "bit", nullable: false),
                    IsMultiFrontage = table.Column<bool>(type: "bit", nullable: false),
                    FrontageCount = table.Column<int>(type: "int", nullable: true),
                    IsBuildable = table.Column<bool>(type: "bit", nullable: false),
                    AllowedDensity = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    AllowedCoverage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    AllowedFloors = table.Column<int>(type: "int", nullable: true),
                    HasWaterConnection = table.Column<bool>(type: "bit", nullable: false),
                    HasElectricityConnection = table.Column<bool>(type: "bit", nullable: false),
                    HasGasConnection = table.Column<bool>(type: "bit", nullable: false),
                    HasSewageConnection = table.Column<bool>(type: "bit", nullable: false),
                    IsFenced = table.Column<bool>(type: "bit", nullable: false),
                    HasBoundaryWall = table.Column<bool>(type: "bit", nullable: false),
                    IsSloped = table.Column<bool>(type: "bit", nullable: false),
                    HasWaterWell = table.Column<bool>(type: "bit", nullable: false),
                    HasWaterRights = table.Column<bool>(type: "bit", nullable: false),
                    LandDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StructureType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConstructionMaterial = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    HasGroundingSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasStandardElectricalSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasStandardPlumbing = table.Column<bool>(type: "bit", nullable: false),
                    HasSafetyCertificate = table.Column<bool>(type: "bit", nullable: false),
                    IsAccessibleForDisabled = table.Column<bool>(type: "bit", nullable: false),
                    HasAccessibilityRamp = table.Column<bool>(type: "bit", nullable: false),
                    IsRetrofitted = table.Column<bool>(type: "bit", nullable: false),
                    StructureDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OccupancyStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsOwnerOccupied = table.Column<bool>(type: "bit", nullable: false),
                    IsRented = table.Column<bool>(type: "bit", nullable: false),
                    IsVacant = table.Column<bool>(type: "bit", nullable: false),
                    IsSuitableForResidence = table.Column<bool>(type: "bit", nullable: false),
                    IsSuitableForOffice = table.Column<bool>(type: "bit", nullable: false),
                    IsSuitableForCommercialUse = table.Column<bool>(type: "bit", nullable: false),
                    IsSuitableForIndustrialUse = table.Column<bool>(type: "bit", nullable: false),
                    IsSuitableForAgriculture = table.Column<bool>(type: "bit", nullable: false),
                    AllowsPets = table.Column<bool>(type: "bit", nullable: false),
                    AllowsShortTermRental = table.Column<bool>(type: "bit", nullable: false),
                    MinimumRentalMonths = table.Column<int>(type: "int", nullable: true),
                    MaximumRentalMonths = table.Column<int>(type: "int", nullable: true),
                    AvailableFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OccupancyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommercialActivityType = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    HasShowcase = table.Column<bool>(type: "bit", nullable: false),
                    ShowcaseLength = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    HasElectricShutter = table.Column<bool>(type: "bit", nullable: false),
                    HasCommercialStorage = table.Column<bool>(type: "bit", nullable: false),
                    HasPrivateRestroom = table.Column<bool>(type: "bit", nullable: false),
                    HasManagementRoom = table.Column<bool>(type: "bit", nullable: false),
                    HasConferenceRoom = table.Column<bool>(type: "bit", nullable: false),
                    HasServerRoom = table.Column<bool>(type: "bit", nullable: false),
                    HasIndependentEntrance = table.Column<bool>(type: "bit", nullable: false),
                    HasBusinessLicense = table.Column<bool>(type: "bit", nullable: false),
                    CanObtainBusinessLicense = table.Column<bool>(type: "bit", nullable: false),
                    ElectricalCapacity = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    EntranceHeight = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    CommercialDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasBackyard = table.Column<bool>(type: "bit", nullable: false),
                    HasBarbecue = table.Column<bool>(type: "bit", nullable: false),
                    HasGazebo = table.Column<bool>(type: "bit", nullable: false),
                    HasWaterFeature = table.Column<bool>(type: "bit", nullable: false),
                    HasPlayground = table.Column<bool>(type: "bit", nullable: false),
                    HasGuestRoom = table.Column<bool>(type: "bit", nullable: false),
                    HasSeparateSuite = table.Column<bool>(type: "bit", nullable: false),
                    HasOutdoorKitchen = table.Column<bool>(type: "bit", nullable: false),
                    HasIndependentWaterMeter = table.Column<bool>(type: "bit", nullable: false),
                    HasIndependentElectricityMeter = table.Column<bool>(type: "bit", nullable: false),
                    HasIndependentGasMeter = table.Column<bool>(type: "bit", nullable: false),
                    BuilderName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OwnerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NeighborhoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowsInPersonVisit = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    VisitDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    InternalNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                        name: "FK_Properties_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "hou",
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Properties_Languages_LanguageId1",
                        column: x => x.LanguageId1,
                        principalSchema: "hou",
                        principalTable: "Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyCategories",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Uncategorized = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SEOTitle = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    IsDraft = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: true),
                    ThumbnailImageName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SmallThumbnailImageName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AltThumbnailImage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LanguageId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyCategories_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "hou",
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropertyCategories_Languages_LanguageId1",
                        column: x => x.LanguageId1,
                        principalSchema: "hou",
                        principalTable: "Languages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropertyCategories_PropertyCategories_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "hou",
                        principalTable: "PropertyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TopBars",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopBars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TopBars_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "hou",
                        principalTable: "Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BlogComments",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AspNetUserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 450, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    IsSeen = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsConfirm = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogComments_AspNetUsers_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalSchema: "hou",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogComments_BlogComments_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "hou",
                        principalTable: "BlogComments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogComments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalSchema: "hou",
                        principalTable: "Blogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BlogFAQs",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogFAQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogFAQs_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalSchema: "hou",
                        principalTable: "Blogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BlogInCategories",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DefaultCategory = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogInCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogInCategories_BlogCategories_BlogCategoryId",
                        column: x => x.BlogCategoryId,
                        principalSchema: "hou",
                        principalTable: "BlogCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogInCategories_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalSchema: "hou",
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogInTags",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogTagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogInTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogInTags_BlogTags_BlogTagId",
                        column: x => x.BlogTagId,
                        principalSchema: "hou",
                        principalTable: "BlogTags",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogInTags_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalSchema: "hou",
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FooterMenus",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FooterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FooterMenus_Footers_FooterId",
                        column: x => x.FooterId,
                        principalSchema: "hou",
                        principalTable: "Footers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FooterMenuItems",
                schema: "hou",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FooterMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterMenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FooterMenuItems_FooterMenus_FooterMenuId",
                        column: x => x.FooterMenuId,
                        principalSchema: "hou",
                        principalTable: "FooterMenus",
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
                name: "IX_BlogCategories_LanguageId",
                schema: "hou",
                table: "BlogCategories",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_LanguageId_IsUncategorized",
                schema: "hou",
                table: "BlogCategories",
                columns: new[] { "LanguageId", "IsUncategorized" });

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_LanguageId_Url",
                schema: "hou",
                table: "BlogCategories",
                columns: new[] { "LanguageId", "Url" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_ParentId",
                schema: "hou",
                table: "BlogCategories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_AspNetUserId",
                schema: "hou",
                table: "BlogComments",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_BlogId",
                schema: "hou",
                table: "BlogComments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_BlogId_IsConfirm_IsDelete",
                schema: "hou",
                table: "BlogComments",
                columns: new[] { "BlogId", "IsConfirm", "IsDelete" });

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_ParentId",
                schema: "hou",
                table: "BlogComments",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogFAQs_BlogId",
                schema: "hou",
                table: "BlogFAQs",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogInCategories_BlogCategoryId",
                schema: "hou",
                table: "BlogInCategories",
                column: "BlogCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogInCategories_BlogId",
                schema: "hou",
                table: "BlogInCategories",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogInCategories_BlogId_BlogCategoryId",
                schema: "hou",
                table: "BlogInCategories",
                columns: new[] { "BlogId", "BlogCategoryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogInTags_BlogId",
                schema: "hou",
                table: "BlogInTags",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogInTags_BlogId_BlogTagId",
                schema: "hou",
                table: "BlogInTags",
                columns: new[] { "BlogId", "BlogTagId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogInTags_BlogTagId",
                schema: "hou",
                table: "BlogInTags",
                column: "BlogTagId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AspNetUserId",
                schema: "hou",
                table: "Blogs",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogCode",
                schema: "hou",
                table: "Blogs",
                column: "BlogCode");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_LanguageId",
                schema: "hou",
                table: "Blogs",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Url",
                schema: "hou",
                table: "Blogs",
                column: "Url");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_IsDelete",
                schema: "hou",
                table: "BlogTags",
                column: "IsDelete");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_TagUrl",
                schema: "hou",
                table: "BlogTags",
                column: "TagUrl",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FooterMenuItems_FooterMenuId",
                schema: "hou",
                table: "FooterMenuItems",
                column: "FooterMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_FooterMenus_FooterId",
                schema: "hou",
                table: "FooterMenus",
                column: "FooterId");

            migrationBuilder.CreateIndex(
                name: "IX_Footers_LanguageId",
                schema: "hou",
                table: "Footers",
                column: "LanguageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HomePages_LanguageId",
                schema: "hou",
                table: "HomePages",
                column: "LanguageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Code",
                schema: "hou",
                table: "Languages",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Culture",
                schema: "hou",
                table: "Languages",
                column: "Culture",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_IsActive",
                schema: "hou",
                table: "Languages",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_IsDefault",
                schema: "hou",
                table: "Languages",
                column: "IsDefault",
                unique: true,
                filter: "[IsDefault] = 1");

            migrationBuilder.CreateIndex(
                name: "IX_NewsletterSubscribers_Email",
                schema: "hou",
                table: "NewsletterSubscribers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NewsletterSubscribers_IsActive",
                schema: "hou",
                table: "NewsletterSubscribers",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_City_PropertyTypeId_TransactionTypeId",
                schema: "hou",
                table: "Properties",
                columns: new[] { "City", "PropertyTypeId", "TransactionTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ExpiresAt",
                schema: "hou",
                table: "Properties",
                column: "ExpiresAt");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_IsApproved",
                schema: "hou",
                table: "Properties",
                column: "IsApproved");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_IsApproved_Status_PublishedAt",
                schema: "hou",
                table: "Properties",
                columns: new[] { "IsApproved", "Status", "PublishedAt" });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_IsFeatured",
                schema: "hou",
                table: "Properties",
                column: "IsFeatured");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_LanguageId",
                schema: "hou",
                table: "Properties",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_LanguageId1",
                schema: "hou",
                table: "Properties",
                column: "LanguageId1");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyCode",
                schema: "hou",
                table: "Properties",
                column: "PropertyCode",
                unique: true,
                filter: "[PropertyCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyTypeId",
                schema: "hou",
                table: "Properties",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PublishedAt",
                schema: "hou",
                table: "Properties",
                column: "PublishedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_Status",
                schema: "hou",
                table: "Properties",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_TransactionTypeId",
                schema: "hou",
                table: "Properties",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UserId",
                schema: "hou",
                table: "Properties",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyCategories_IsDraft",
                schema: "hou",
                table: "PropertyCategories",
                column: "IsDraft");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyCategories_LanguageId",
                schema: "hou",
                table: "PropertyCategories",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyCategories_LanguageId_ParentId",
                schema: "hou",
                table: "PropertyCategories",
                columns: new[] { "LanguageId", "ParentId" });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyCategories_LanguageId_Url",
                schema: "hou",
                table: "PropertyCategories",
                columns: new[] { "LanguageId", "Url" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyCategories_LanguageId1",
                schema: "hou",
                table: "PropertyCategories",
                column: "LanguageId1");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyCategories_ParentId",
                schema: "hou",
                table: "PropertyCategories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_TopBars_LanguageId",
                schema: "hou",
                table: "TopBars",
                column: "LanguageId",
                unique: true);
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
                name: "BlogComments",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "BlogFAQs",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "BlogInCategories",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "BlogInTags",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "FooterMenuItems",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "HomePages",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "NewsletterSubscribers",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "Properties",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "PropertyCategories",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "SocialNetworks",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "TopBars",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "BlogCategories",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "BlogTags",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "Blogs",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "FooterMenus",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "Footers",
                schema: "hou");

            migrationBuilder.DropTable(
                name: "Languages",
                schema: "hou");
        }
    }
}
