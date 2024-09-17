using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class init31Auh24v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                schema: "AuctionDB",
                table: "Product",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Designation",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9882));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 12, 865, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 12, 865, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 12, 865, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 12, 865, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 12, 865, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 12, 865, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 12, 865, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 8, 13, 11, 41, 13, 36, DateTimeKind.Utc).AddTicks(3351), "$2a$11$urJhnxkT/27UkZaWQyW/XOULXe5lFcH43sgkG36Yc7DcRBE2FYJVO" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 8, 13, 11, 41, 13, 204, DateTimeKind.Utc).AddTicks(4227), "$2a$11$N7qDDJ.uv2kjFM3Ew9L/Qu3gfJQoSuwlCddTLElf.jfoOAGXeKco." });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 8, 13, 11, 41, 13, 363, DateTimeKind.Utc).AddTicks(3977), "$2a$11$d0eW1YZP7f7bGVqOUWeGiuRytXDPwEr/MTpLGezSwIpnkYy0ebxB6" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(8639), "$2a$11$AN0oa6iZVJgJo6T9WN1EAObtwJc1iGeVHQztniWYdLaz8CQgIvMKS" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9728));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 11, 41, 13, 525, DateTimeKind.Utc).AddTicks(9599));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                schema: "AuctionDB",
                table: "Product");

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
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 5, 24, 158, DateTimeKind.Utc).AddTicks(3536), "$2a$11$izSDQh9f2Y/IKISga.GNdOvje7u/qKwGCtaxHYfZpCgEqDF/O1Siy" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 5, 24, 284, DateTimeKind.Utc).AddTicks(8306), "$2a$11$UIU1JQs7WKB9ORtau5TuPuAYOU4M1Y7iTdtglguVeDj/D/aE8.L4m" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 5, 24, 414, DateTimeKind.Utc).AddTicks(9242), "$2a$11$HVBrG2jFj8Ov5LLQD5FX9OSYxCgJi7NA1JKZggsfXYzuCxQRBJyeK" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 5, 24, 532, DateTimeKind.Utc).AddTicks(5001), "$2a$11$tQBMuPYxuhgc7MciscZGquY9QrvjvY/5Y1a98P5oy8hY8CUAAU3f6" });

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
    }
}
