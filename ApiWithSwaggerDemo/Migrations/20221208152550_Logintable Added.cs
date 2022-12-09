using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiWithSwaggerDemo.Migrations
{
    public partial class LogintableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Departments",
            //    columns: table => new
            //    {
            //        DepartmentId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DepartmentName = table.Column<string>(nullable: true),
            //        Location = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Departments", x => x.DepartmentId);
            //    });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.UserId);
                });

            //migrationBuilder.CreateTable(
            //    name: "Employees",
            //    columns: table => new
            //    {
            //        EmployeeId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(nullable: true),
            //        Email = table.Column<string>(nullable: true),
            //        Gender = table.Column<string>(nullable: true),
            //        Salary = table.Column<int>(nullable: false),
            //        DepartmentId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Employees", x => x.EmployeeId);
            //        table.ForeignKey(
            //            name: "FK_Employees_Departments_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "Departments",
            //            principalColumn: "DepartmentId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Employees_DepartmentId",
            //    table: "Employees",
            //    column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
