using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorDemo.Server.Data.Migrations
{
    public partial class CreateIdentitySchema1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4203f28f-602a-4f0f-b0ba-44cfc815a9a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ae4306f-350c-4747-89b4-fd180a878230");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd886046-c593-4198-ac1a-27b5eff2c8e7", "8780a96d-8f62-43e1-890f-1635add7bd73", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4df4e758-a7f2-4e28-b1f5-a381a87d94a3", "611eb5a8-6ae4-4315-98d2-14d7742f656a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "751368bd-7da8-497d-af64-ba786b36c6d0", "cfe99f9a-c241-4e03-bdb8-0a4f6bf80994", "SuperAdmin", "SUPERADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4df4e758-a7f2-4e28-b1f5-a381a87d94a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "751368bd-7da8-497d-af64-ba786b36c6d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd886046-c593-4198-ac1a-27b5eff2c8e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4203f28f-602a-4f0f-b0ba-44cfc815a9a1", "1f09fb46-f2b7-419a-a7d2-f41fb13d8a52", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ae4306f-350c-4747-89b4-fd180a878230", "777f6b22-f2c5-422f-8a5e-9fce61ab3a89", "Admin", "ADMIN" });
        }
    }
}
