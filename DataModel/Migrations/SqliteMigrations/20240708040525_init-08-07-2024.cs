using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class init08072024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordResetToken",
                schema: "UserDM",
                table: "User",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Designation",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 40, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 40, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 40, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 40, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 40, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 40, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 40, DateTimeKind.Utc).AddTicks(2153));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "PasswordResetToken" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 5, 24, 158, DateTimeKind.Utc).AddTicks(3536), "$2a$11$izSDQh9f2Y/IKISga.GNdOvje7u/qKwGCtaxHYfZpCgEqDF/O1Siy", "" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "PasswordResetToken" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 5, 24, 284, DateTimeKind.Utc).AddTicks(8306), "$2a$11$UIU1JQs7WKB9ORtau5TuPuAYOU4M1Y7iTdtglguVeDj/D/aE8.L4m", "" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "PasswordResetToken" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 5, 24, 414, DateTimeKind.Utc).AddTicks(9242), "$2a$11$HVBrG2jFj8Ov5LLQD5FX9OSYxCgJi7NA1JKZggsfXYzuCxQRBJyeK", "" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password", "PasswordResetToken" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5001), "$2a$11$tQBMuPYxuhgc7MciscZGquY9QrvjvY/5Y1a98P5oy8hY8CUAAU3f6", "" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5715));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordResetToken",
                schema: "UserDM",
                table: "User");

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
    }
}
