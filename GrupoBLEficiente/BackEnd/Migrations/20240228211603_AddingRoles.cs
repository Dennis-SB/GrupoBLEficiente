using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations
{
    public partial class AddingRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0fb8be84-7c9f-48b5-98bd-083e330f5820", "1", "Administrador", "Administrador" },
                    { "71865197-69f9-4465-a454-b29fe513affa", "3", "Ventas", "Ventas" },
                    { "843e3955-91a7-4e3d-b8bb-6ffa7cd2e9e5", "4", "Administrativo", "Administrativo" },
                    { "a5b38923-8d36-4473-9d7c-391564c6474f", "2", "Soporte", "Soporte" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fb8be84-7c9f-48b5-98bd-083e330f5820");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71865197-69f9-4465-a454-b29fe513affa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "843e3955-91a7-4e3d-b8bb-6ffa7cd2e9e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5b38923-8d36-4473-9d7c-391564c6474f");
        }
    }
}
