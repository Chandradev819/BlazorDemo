using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorDemo.Server.Data.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(nullable: true),
                    PolicyName = table.Column<string>(nullable: true),
                    IconName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItems");

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
    }
}
