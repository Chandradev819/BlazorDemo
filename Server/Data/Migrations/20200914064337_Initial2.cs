using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorDemo.Server.Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a8f7a5b-2281-496a-8ee9-ecfd3622d92e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c344e73b-7985-45dc-8601-d745588fae8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddf0d288-cc60-4bfc-b3d1-0d50e33faaa1");

            migrationBuilder.AddColumn<string>(
                name: "MenuName",
                table: "MenuItems",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d15ebf45-a1bc-4f88-9ac9-1507dc64312c", "21c37fa1-de1a-4faf-8b8c-e79e15ce4516", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2a7404c-9ab1-4e96-9102-79fd5c5e5bd6", "854e390f-3060-4b51-b4d6-714bfba69bb4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1dca64d1-fa85-410b-aae8-1bc882a2061d", "34b586b5-d509-4d0e-8c68-04dfabf550ec", "SuperAdmin", "SUPERADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dca64d1-fa85-410b-aae8-1bc882a2061d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d15ebf45-a1bc-4f88-9ac9-1507dc64312c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2a7404c-9ab1-4e96-9102-79fd5c5e5bd6");

            migrationBuilder.DropColumn(
                name: "MenuName",
                table: "MenuItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c344e73b-7985-45dc-8601-d745588fae8a", "8c13bbd0-b013-4b91-bc9e-ad0fba20241e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ddf0d288-cc60-4bfc-b3d1-0d50e33faaa1", "07dfa6d0-b55b-4b26-9ae7-9b5331a06260", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a8f7a5b-2281-496a-8ee9-ecfd3622d92e", "2fc519ca-d25c-44ac-b579-860988b4b0e0", "SuperAdmin", "SUPERADMIN" });
        }
    }
}
