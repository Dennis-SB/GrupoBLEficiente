using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations
{
    public partial class DBEmployeeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEmployee",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEmployeeNavigationIdEmployee",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    IdJobTitle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JobTitle__A427B021B31D2418", x => x.IdJobTitle);
                });

            migrationBuilder.CreateTable(
                name: "NationalIdTypes",
                columns: table => new
                {
                    IdType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__National__9A39EABC1B11A5EC", x => x.IdType);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    IdEmployee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdType = table.Column<int>(type: "int", nullable: true),
                    NationalId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    HireDate = table.Column<DateTime>(type: "date", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IdJobTitle = table.Column<int>(type: "int", nullable: true),
                    MonthlyGrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__51C8DD7AB78B16FA", x => x.IdEmployee);
                    table.ForeignKey(
                        name: "FK__Employees__IdJob__3E52440B",
                        column: x => x.IdJobTitle,
                        principalTable: "JobTitles",
                        principalColumn: "IdJobTitle");
                    table.ForeignKey(
                        name: "FK__Employees__IdTyp__3D5E1FD2",
                        column: x => x.IdType,
                        principalTable: "NationalIdTypes",
                        principalColumn: "IdType");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IdEmployeeNavigationIdEmployee",
                table: "AspNetUsers",
                column: "IdEmployeeNavigationIdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdJobTitle",
                table: "Employees",
                column: "IdJobTitle");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdType",
                table: "Employees",
                column: "IdType");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Employees_IdEmployeeNavigationIdEmployee",
                table: "AspNetUsers",
                column: "IdEmployeeNavigationIdEmployee",
                principalTable: "Employees",
                principalColumn: "IdEmployee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Employees_IdEmployeeNavigationIdEmployee",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "NationalIdTypes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_IdEmployeeNavigationIdEmployee",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10b2b4d1-60fd-4664-a306-d0a430e18641");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "128af814-3c79-48da-9d39-4a636816489e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30e78697-97da-44f0-b4c2-0c34283dbf60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc08359e-bf89-4d89-bbb7-9e3bf361e6a4");

            migrationBuilder.DropColumn(
                name: "IdEmployee",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdEmployeeNavigationIdEmployee",
                table: "AspNetUsers");

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
    }
}
