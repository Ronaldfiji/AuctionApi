using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class initial_160424v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Designation",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 21, 779, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 21, 779, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 21, 779, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 21, 779, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 21, 779, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 21, 779, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 21, 779, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 6, 21, 897, DateTimeKind.Utc).AddTicks(6167), "$2a$11$AJgLtawkOd3ZVp8O5N9prO9pjLIsP4ot.yQjljPGAHh.CWwm/Q3/i" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 6, 22, 17, DateTimeKind.Utc).AddTicks(6228), "$2a$11$cuyfsDJ.UhOaWloBWi/d/uGAeEtOFcF1.ltpCI4b8BXYcx89QaqaS" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 6, 22, 137, DateTimeKind.Utc).AddTicks(1634), "$2a$11$RgJVZce83BN1bYMVIEUKPOkUk3F/glR2iXxvx6j39LTGQETnVAjA." });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 6, 22, 254, DateTimeKind.Utc).AddTicks(9724), "$2a$11$dujJ4OWfcjyC88kN6zPONeaoxQPxx6ZwPzZRcX7VtQ3ujbqX6manm" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(412));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 14, 6, 22, 255, DateTimeKind.Utc).AddTicks(363));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Designation",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 11, 44, 37, 627, DateTimeKind.Utc).AddTicks(5034));

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
    }
}
