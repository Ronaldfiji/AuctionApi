using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataModel.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class initial_150424 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AuctionDB");

            migrationBuilder.EnsureSchema(
                name: "UserDM");

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "AuctionDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ItemCondition",
                schema: "AuctionDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    State = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCondition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "UserDM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                schema: "UserDM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 1, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "UserDM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    DOB = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 12, nullable: false),
                    AddressLine1 = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    State = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ImagePath = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserTypeID = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_UserType_UserTypeID",
                        column: x => x.UserTypeID,
                        principalSchema: "UserDM",
                        principalTable: "UserType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "AuctionDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "TEXT", precision: 9, scale: 2, nullable: false),
                    Lng = table.Column<float>(type: "REAL", nullable: true),
                    Lat = table.Column<float>(type: "REAL", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    InspectionDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InspectionSummary = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    AuctionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AuctionEndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AuctioneerId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemConditionID = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalSchema: "AuctionDB",
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ItemCondition_ItemConditionID",
                        column: x => x.ItemConditionID,
                        principalSchema: "AuctionDB",
                        principalTable: "ItemCondition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_User_AuctioneerId",
                        column: x => x.AuctioneerId,
                        principalSchema: "UserDM",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                schema: "UserDM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false),
                    JwtId = table.Column<string>(type: "TEXT", nullable: false),
                    IsUsed = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsRevorked = table.Column<bool>(type: "INTEGER", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedByIp = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "UserDM",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPictures",
                schema: "UserDM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Path = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AppUserID = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPictures", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserPictures_User_AppUserID",
                        column: x => x.AppUserID,
                        principalSchema: "UserDM",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "UserDM",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "UserDM",
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "UserDM",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bid",
                schema: "AuctionDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BidderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductID = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", precision: 9, scale: 2, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bid_Product_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "AuctionDB",
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bid_User_BidderId",
                        column: x => x.BidderId,
                        principalSchema: "UserDM",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPictures",
                schema: "AuctionDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Path = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ProductID = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPictures", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductPictures_Product_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "AuctionDB",
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "AuctionDB",
                table: "Category",
                columns: new[] { "ID", "Code", "CreatedBy", "CreatedDate", "Description", "IPAddress", "Icon", "ModifiedDate", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "CAT0001", "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3586), "Automotive and Spare parts category", "10.56.89.255", "LocalShipping", null, "Automotive and Spare parts", "Ron_up" },
                    { 2, "CAT0002", "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3589), "Cell Phones & Accessories category", "10.56.89.255", "LocalShipping", null, "Cell Phones & Accessories", "Ron_up" },
                    { 3, "CAT0003", "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3591), "Cell Phones & Accessories category", "10.56.89.255", "LocalShipping", null, "Consumer Electronics", "Ron_up" },
                    { 4, "CAT0004", "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3592), "Jewelry & Watches category", "10.56.89.255", "LocalShipping", null, "Jewelry & Watches", "Ron_up" },
                    { 5, "CAT0005", "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3594), "Consumer Electronics category", "10.56.89.255", "LocalShipping", null, "Consumer Electronics", "Ron_up" },
                    { 6, "CAT0006", "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3595), "Real Estate category", "10.56.89.255", "LocalShipping", null, "Real Estate", "Ron_up" }
                });

            migrationBuilder.InsertData(
                schema: "AuctionDB",
                table: "ItemCondition",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ModifiedDate", "State", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3647), "A brand-new, unused, unopened, unworn, undamaged item. Most categories support this condition (as long as condition is an applicable concept.", "10.56.89.255", null, "New", "Ron_up" },
                    { 2, "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3650), "A brand-new new, unused item with no signs of wear. Packaging may be missing or opened. The item may be a factory second or have defects", "10.56.89.255", null, "New other", "Ron_up" },
                    { 3, "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3652), "A brand-new, unused, and unworn item. The item may have cosmetic defects, and/or may contain mismarked tags (e.g., incorrect size tags from the manufacturer). Packaging may be missing or opened. The item may be a new factory second or irregular.", "10.56.89.255", null, "New with defects", "Ron_up" },
                    { 4, "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3653), "The item is in a pristine, like-new condition. It has been professionally inspected, cleaned, and refurbished by the manufacturer or a manufacturer-approved vendor to meet manufacturer specifications. The item will be in new packaging with original or new accessories.", "10.56.89.255", null, "Refurbished", "Ron_up" },
                    { 5, "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3655), "The item is in like-new condition, backed by a one year warranty. It has been professionally refurbished, inspected, and cleaned to excellent condition by qualified sellers. The item includes original or new accessories and will come in new generic packaging. See the seller's listing for full details.", "10.56.89.255", null, "Excellent - Refurbished", "Ron_up" },
                    { 6, "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3657), "An item that looks as if it was just taken out of shrink wrap. No visible wear, and all facets of the item are flawless and intact. See the seller's listing for full details and description of any imperfections.", "10.56.89.255", null, "Like New", "Ron_up" },
                    { 7, "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3658), "An item that has been used previously. The item may have some signs of cosmetic wear, but is fully operational and functions as intended. This item may be a floor model or store return that has been used. Most categories support this condition (as long as condition is an applicable concept).", "10.56.89.255", null, "Used", "Ron_up" },
                    { 8, "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3659), "An item that is used but still in very good condition. No obvious damage to the cover or jewel case. No missing or damaged pages or liner notes. The instructions (if applicable) are included in the box. May have very minimal identifying marks on the inside cover. Very minimal wear and tear.", "10.56.89.255", null, "Very Good", "Ron_up" },
                    { 9, "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3660), "An item with obvious or significant wear, but still operational. For books, liner notes, or instructions, the item may have some damage to the cover but the integrity is still intact. Instructions and/or box may be missing. For books, possible writing in margins, etc., but no missing pages or anything that would compromise the legibility or understanding of the text.", "10.56.89.255", null, "Acceptable", "Ron_up" },
                    { 10, "Ron_cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3661), "An item that does not function as intended and is not fully operational. This includes items that are defective in ways that render them difficult to use, items that require service or repair, or items missing essential components. Supported in categories where parts or non-working items are of interest to people who repair or collect related items.", "10.56.89.255", null, "For parts or not working", "Ron_up" }
                });

            migrationBuilder.InsertData(
                schema: "UserDM",
                table: "Role",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ModifiedDate", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(4925), "User role", "", null, "User", "" },
                    { 2, "", new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(4962), "Admin role", "", null, "Admin", "" },
                    { 3, "", new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(5004), "HOD role", "", null, "HOD", "" },
                    { 4, "", new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(5023), "Manager role", "", null, "Manager", "" },
                    { 5, "", new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(5040), "Master Admin role", "", null, "MasterAdmin", "" },
                    { 6, "", new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(5058), "HR Admin", "", null, "HROffice", "" },
                    { 7, "", new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(5075), "Director role", "", null, "Director", "" }
                });

            migrationBuilder.InsertData(
                schema: "UserDM",
                table: "UserType",
                columns: new[] { "ID", "Code", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ModifiedDate", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "C", "", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3387), "Organisation or Individual who receives service.", "", null, "Client", "" },
                    { 2, "B", "", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3389), "Service provider", "", null, "Enterprise", "" }
                });

            migrationBuilder.InsertData(
                schema: "UserDM",
                table: "User",
                columns: new[] { "ID", "AddressLine1", "AddressLine2", "City", "Country", "CreatedBy", "CreatedDate", "DOB", "Email", "FirstName", "Gender", "IPAddress", "ImagePath", "IsActive", "LastName", "ModifiedDate", "Password", "Phone", "PostalCode", "State", "UpdatedBy", "UserTypeID" },
                values: new object[,]
                {
                    { 1, "First Road X road", "10 , Fox Street", "Levuka", "Fiji", "Admin-cr", new DateTime(2024, 4, 15, 16, 2, 59, 726, DateTimeKind.Utc).AddTicks(1840), new DateTime(1956, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", "Admin", 3, "107.23.365.369", "", true, "Limited", null, "$2a$11$XlaYXExL9pfGcPzEwx8dF.nRRHqFruwPzCgSeVqZ2GX44DoC5VJ1e", "9090337", "0123", "BlackWater", "Manager-up", 1 },
                    { 2, "Fula Fula Road", "10, Black street", "Apia", "Samoa", "Admin-cr", new DateTime(2024, 4, 15, 16, 2, 59, 852, DateTimeKind.Utc).AddTicks(8998), new DateTime(1979, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@mail.com", "John", 1, "107.23.365.369", "", true, "Smith", null, "$2a$11$MUKjD07ePhnqDtVXY56H0O5Mmi//BusAx3IyCXtRnkvh90gwqR7fC", "74789699", "458", "North", "Admin-up", 1 },
                    { 3, "Rock line Island", "29, Bush mount road", "Port Vila", "Vanuatu", "Admin-cr", new DateTime(2024, 4, 15, 16, 2, 59, 987, DateTimeKind.Utc).AddTicks(6184), new DateTime(1983, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter@mail.com", "Peter", 3, "107.23.365.369", "", true, "Gates", null, "$2a$11$vupu80/prMuaQuFkZVlJXuPzyRwRpsJCKprLs7oi7Irdn3uXjfZXC", "8890337", "889", "Ocean", "Admin-up", 1 },
                    { 4, "Manukau Cresent", "41, Black place", "Auckland", "New zealand", "Admin-cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(1770), new DateTime(1983, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "monika@mail.com", "Monika", 2, "107.23.365.369", "", true, "Kumar", null, "$2a$11$3d9SJ87Bk9/Gn.A9uR5Qv.dgqcSMnstm0exPG62MouPQSPPUCJIR2", "9090337", "064", "North", "Admin-up", 1 }
                });

            migrationBuilder.InsertData(
                schema: "UserDM",
                table: "UserRole",
                columns: new[] { "RoleId", "UserId", "CreatedBy", "CreatedDate", "IPAddress", "ModifiedDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "Admin-cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3438), "107.23.365.369", null, "Admin-up" },
                    { 5, 1, "Admin-cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3440), "107.23.365.369", null, "Admin-up" },
                    { 7, 1, "Admin-cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3442), "107.23.365.369", null, "Admin-up" },
                    { 1, 2, "Admin-cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3444), "107.23.365.369", null, "Admin-up" },
                    { 1, 3, "Admin-cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3445), "107.23.365.369", null, "Admin-up" },
                    { 2, 3, "Admin-cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3447), "107.23.365.369", null, "Admin-up" },
                    { 5, 3, "Admin-cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3448), "107.23.365.369", null, "Admin-up" },
                    { 1, 4, "Admin-cr", new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3450), "107.23.365.369", null, "Admin-up" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bid_BidderId",
                schema: "AuctionDB",
                table: "Bid",
                column: "BidderId");

            migrationBuilder.CreateIndex(
                name: "IX_Bid_ProductID",
                schema: "AuctionDB",
                table: "Bid",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_Code",
                schema: "AuctionDB",
                table: "Category",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_AuctioneerId",
                schema: "AuctionDB",
                table: "Product",
                column: "AuctioneerId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                schema: "AuctionDB",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ItemConditionID",
                schema: "AuctionDB",
                table: "Product",
                column: "ItemConditionID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPictures_ProductID",
                schema: "AuctionDB",
                table: "ProductPictures",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                schema: "UserDM",
                table: "RefreshToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                schema: "UserDM",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeID",
                schema: "UserDM",
                table: "User",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPictures_AppUserID",
                schema: "UserDM",
                table: "UserPictures",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                schema: "UserDM",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserType_Code",
                schema: "UserDM",
                table: "UserType",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bid",
                schema: "AuctionDB");

            migrationBuilder.DropTable(
                name: "ProductPictures",
                schema: "AuctionDB");

            migrationBuilder.DropTable(
                name: "RefreshToken",
                schema: "UserDM");

            migrationBuilder.DropTable(
                name: "UserPictures",
                schema: "UserDM");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "UserDM");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "AuctionDB");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "UserDM");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "AuctionDB");

            migrationBuilder.DropTable(
                name: "ItemCondition",
                schema: "AuctionDB");

            migrationBuilder.DropTable(
                name: "User",
                schema: "UserDM");

            migrationBuilder.DropTable(
                name: "UserType",
                schema: "UserDM");
        }
    }
}
