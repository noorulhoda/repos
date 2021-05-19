using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore3_day4_5.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Departments");

            migrationBuilder.AddColumn<string>(
                name: "Dept_Name",
                table: "Departments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dept_Name",
                table: "Departments");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
