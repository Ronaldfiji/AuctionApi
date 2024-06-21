using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class init130624v1 : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Designation",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 18, 663, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 18, 663, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 18, 663, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 18, 663, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 18, 663, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 18, 663, DateTimeKind.Utc).AddTicks(5996));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 18, 663, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 7, 13, 25, 18, 794, DateTimeKind.Utc).AddTicks(3243), "$2a$11$FqsjQf51pMqY8kcmssdBV.hOAvFmACvWaKFqsNBVmy.d/0FLEi192" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 7, 13, 25, 18, 936, DateTimeKind.Utc).AddTicks(7250), "$2a$11$3HWlqL1b3TPSzvfGpL9.3.jxsum7Rwh/w3W.xYl.MT3ShcB6qwjMS" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 7, 13, 25, 19, 91, DateTimeKind.Utc).AddTicks(947), "$2a$11$v8KcTKAAD3XRSDL3SV6QruGYSK3HXlFdzMLR80fFAJQAlsxF.zEH2" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(5058), "$2a$11$tQahBeGy6/PJXwpr3GWOXu5TeXLgQ8d7HJ/TR5Bqr4/RsPKYRUh.a" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 13, 25, 19, 215, DateTimeKind.Utc).AddTicks(6309));
        }
    }
}
