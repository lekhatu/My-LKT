using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreApple.Migrations
{
    public partial class CreatingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5444f253-6924-4935-9321-7292331eea4d", "80a1963b-7822-4567-b131-64748bed2cfd", "Visitor", "VISITOR" },
                    { "9b795157-73f4-4adb-a8f0-71280e358fb4", "0af8cc60-2667-405a-be3e-63c234310a7b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 32, 414, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 32, 415, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 32, 415, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 32, 415, DateTimeKind.Local).AddTicks(5124));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5444f253-6924-4935-9321-7292331eea4d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b795157-73f4-4adb-a8f0-71280e358fb4");

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
    }
}
