using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore3_day4_5.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Dept_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Dept_Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Ins_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ins_Name = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Dept_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Ins_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
