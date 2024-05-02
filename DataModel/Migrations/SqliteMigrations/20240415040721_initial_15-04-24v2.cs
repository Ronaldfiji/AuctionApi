using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class initial_150424v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                schema: "AuctionDB",
                table: "Product",
                type: "TEXT",
                precision: 2,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                schema: "AuctionDB",
                table: "Product");

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                schema: "AuctionDB",
                table: "ItemCondition",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "Role",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 2, 59, 602, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 2, 59, 726, DateTimeKind.Utc).AddTicks(1840), "$2a$11$XlaYXExL9pfGcPzEwx8dF.nRRHqFruwPzCgSeVqZ2GX44DoC5VJ1e" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 2, 59, 852, DateTimeKind.Utc).AddTicks(8998), "$2a$11$MUKjD07ePhnqDtVXY56H0O5Mmi//BusAx3IyCXtRnkvh90gwqR7fC" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 2, 59, 987, DateTimeKind.Utc).AddTicks(6184), "$2a$11$vupu80/prMuaQuFkZVlJXuPzyRwRpsJCKprLs7oi7Irdn3uXjfZXC" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "User",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(1770), "$2a$11$3d9SJ87Bk9/Gn.A9uR5Qv.dgqcSMnstm0exPG62MouPQSPPUCJIR2" });

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                schema: "UserDM",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 0, 118, DateTimeKind.Utc).AddTicks(3389));
        }
    }
}
