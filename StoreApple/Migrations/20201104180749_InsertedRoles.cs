using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreApple.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "87738e38-3351-48fd-9e89-8293229b2a37", "17c0cc36-57cb-4423-bd82-878a6ba1db9d", "Visitor", "VISITOR" },
                    { "10e99e85-2ceb-4259-b16c-172717b09cf0", "b7ce3da2-3441-4210-933b-258600ee483c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 48, 596, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 48, 598, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 48, 598, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 11, 5, 1, 7, 48, 598, DateTimeKind.Local).AddTicks(702));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10e99e85-2ceb-4259-b16c-172717b09cf0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87738e38-3351-48fd-9e89-8293229b2a37");

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
    }
}
