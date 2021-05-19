using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore3_day4_5.Migrations
{
    public partial class frth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dept_Id1",
                table: "Instructors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_Id1",
                table: "Instructors",
                column: "Dept_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_Id1",
                table: "Instructors",
                column: "Dept_Id1",
                principalTable: "Departments",
                principalColumn: "Dept_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_Id1",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_Id1",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Dept_Id1",
                table: "Instructors");
        }
    }
}
