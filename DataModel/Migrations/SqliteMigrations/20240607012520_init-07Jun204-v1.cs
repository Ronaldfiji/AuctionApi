using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.migrations.sqlitemigrations
{
    /// <inheritdoc />
    public partial class init07Jun204v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "JobPost",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Organisation_Code",
                schema: "JobsDB",
                table: "Organisation",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_UserID",
                table: "JobPost",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_User_UserID",
                table: "JobPost",
                column: "UserID",
                principalSchema: "UserDM",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_User_UserID",
                table: "JobPost");

            migrationBuilder.DropIndex(
                name: "IX_Organisation_Code",
                schema: "JobsDB",
                table: "Organisation");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_UserID",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "JobPost");

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Designation",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 160, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 160, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 160, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 160, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 160, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 160, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 160, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 5, 24, 12, 29, 53, 280, DateTimeKind.Utc).AddTicks(1744), "$2a$11$QqZ7b2cisdZ7isOdtVtoQemC6N/K.vxW3mXvLlhpwnxK.z5w9HQ4." });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 5, 24, 12, 29, 53, 400, DateTimeKind.Utc).AddTicks(3304), "$2a$11$K.hr.35FHkgAnp3Uk0CXEeicUbamtPB09UDI3qBfCK.Qs1ChNOWQW" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 5, 24, 12, 29, 53, 528, DateTimeKind.Utc).AddTicks(8786), "$2a$11$r3H8lA1./lZzdjzCXTR2n.kHmX5/ls8NrRAxgz9sNYMCgu3vSRn2u" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(2831), "$2a$11$epuV6N0Foxx.xbZe37Y6W.JJ.k4vES57WVkJ2Yb9JGG9wUlVT8R9K" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 12, 29, 53, 652, DateTimeKind.Utc).AddTicks(3481));
        }
    }
}
