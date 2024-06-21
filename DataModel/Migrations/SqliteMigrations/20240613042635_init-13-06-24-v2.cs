using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class init130624v2 : Migration
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
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Designation",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9738));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9739));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 34, 880, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 34, 880, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 34, 880, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 34, 880, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 34, 880, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 34, 880, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 34, 880, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 26, 35, 2, DateTimeKind.Utc).AddTicks(5519), "$2a$11$sv7STXjWFSQqwKw//5UpD.ei8LDfkNQCRjKL0oyYe17n3STCGOHgW" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 26, 35, 136, DateTimeKind.Utc).AddTicks(1147), "$2a$11$m2pNH1N5MdBFGZCkdVwLUuSOs/DHm52/AWlkFbxwbLKYkRHbtTS/." });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 26, 35, 264, DateTimeKind.Utc).AddTicks(2563), "$2a$11$2HA4ENVw8plPk4bbrtPva.THEdZwV0cGggcxW0qc4Gglmp1QHQGvi" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(8887), "$2a$11$xrnnegtGJ7LuL9y6SLtBreVhpv3wQT9aiavVezUlYL5.d/4C16T9i" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 26, 35, 384, DateTimeKind.Utc).AddTicks(9584));
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
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Designation",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 436, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 436, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 436, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 436, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 436, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 436, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 436, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 12, 5, 556, DateTimeKind.Utc).AddTicks(1047), "$2a$11$SsRQ7L6cjqZ61wqfFMEkROSbfxW64wyjicaLj/YQ1YqfbJVWN/KZS" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 12, 5, 693, DateTimeKind.Utc).AddTicks(4964), "$2a$11$E3DQHRVceAYK9sL0EkYFjOHT6RMx7kuSDPLynTI7N.Qgopabix32i" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 12, 5, 828, DateTimeKind.Utc).AddTicks(1877), "$2a$11$idCFSadEGBvORswYtpIQlukiefwpOs/oQrcUgSXE2DO4wsXpnePBa" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(6937), "$2a$11$iFINA/mulKt1tOdqiYS3MeLUB524f7pEa4mZVo/F3JjGzu0redG6G" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 16, 12, 5, 951, DateTimeKind.Utc).AddTicks(7535));
        }
    }
}
