using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreApple.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83e34705-6054-4c11-88e7-9e0ff11d92f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88420631-4d14-4686-9494-4b18cd80d2c1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60c3ea35-f9ee-402f-9a0a-34133cd91fb4", "39124e44-b3aa-4eff-ab1d-8fc0c6650a74", "Visitor", "VISITOR" },
                    { "994d8b92-7298-467a-a7c7-d0cbfd6b8229", "02abb897-885f-4c62-b7ff-9aa018dbe80a", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 8, 237, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 8, 238, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 8, 238, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 8, 238, DateTimeKind.Local).AddTicks(3702));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60c3ea35-f9ee-402f-9a0a-34133cd91fb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "994d8b92-7298-467a-a7c7-d0cbfd6b8229");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "88420631-4d14-4686-9494-4b18cd80d2c1", "aa3d8d23-d01d-4d95-9203-1e0a9b53992a", "Visitor", "VISITOR" },
                    { "83e34705-6054-4c11-88e7-9e0ff11d92f2", "d2d6c0c8-25eb-48fa-8e9b-4635592f1d5b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 5, 52, 811, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 5, 52, 813, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 5, 52, 813, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 5, 52, 813, DateTimeKind.Local).AddTicks(1461));
        }
    }
}
