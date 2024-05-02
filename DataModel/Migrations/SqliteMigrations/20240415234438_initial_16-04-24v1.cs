using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class initial_160424v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Designation",
                schema: "AuctionDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobTitle = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DesignationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.ID);
                });

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4903));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.InsertData(
                schema: "AuctionDB",
                table: "Designation",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Description", "DesignationDate", "IPAddress", "JobTitle", "ModifiedDate", "UpdatedBy" },
                values: new object[] { 1, "Ron_cr", new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(5034), "Senior full-stack software engineer", null, "10.56.89.255", "Senior Software Engineer", null, "Ron_up" });

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4966));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 84, DateTimeKind.Utc).AddTicks(1824));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 84, DateTimeKind.Utc).AddTicks(1856));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 84, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 84, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 84, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 84, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 84, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 16, 11, 44, 37, 212, DateTimeKind.Utc).AddTicks(7196), "$2a$11$.BYIgHk1fGMejSTlvzAue.yZMoQ1eWj02JbSclFFEbWxiVeWBgdQ2" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 16, 11, 44, 37, 351, DateTimeKind.Utc).AddTicks(1205), "$2a$11$.GPwCYjpApa9HIb3DstJB.RJ4KWYcV45BjnJm3WCZA2vMWIajqfqK" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 16, 11, 44, 37, 479, DateTimeKind.Utc).AddTicks(7436), "$2a$11$PqGZJbuObRqGXv5ttzU7cOL9YE3/s62LyJB/nkbHeapXz1Bt./4de" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(3943), "$2a$11$cqSN9g/CW3LwqLckuHv7..TqXDXmJlRRCJCzSL/gTGjnsvqRVd8Pi" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4767));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(4769));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Designation",
                schema: "AuctionDB");

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 782, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 782, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 286, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 286, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 286, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 286, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 286, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 286, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 286, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 7, 20, 407, DateTimeKind.Utc).AddTicks(6641), "$2a$11$vIKii6ZtRhgNncujQWkspO8okK4uluiFre2I1I/8l8tW3IJgRDy12" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 7, 20, 532, DateTimeKind.Utc).AddTicks(1815), "$2a$11$MCM5sI8v68XYQQqA1EicfuFBFb0s.uwki76SP83KmsJ4rMqH5NmYq" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 7, 20, 659, DateTimeKind.Utc).AddTicks(2253), "$2a$11$SbuXOItiA4M48S3Vx.jCmO1axCeUKNzjpENAuif9XbSAdp7VX4HQS" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(8658), "$2a$11$MzZt.xkyQrsJNdvsGyFFgeTSryVqKhHIOPk/yBZmG7U9BUlkowV7C" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 7, 20, 781, DateTimeKind.Utc).AddTicks(9649));
        }
    }
}
