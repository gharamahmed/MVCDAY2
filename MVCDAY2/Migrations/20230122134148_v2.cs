using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDAY2.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependents_Employees_EmployeeSSN",
                table: "Dependents");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Departments_departmentNumber",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_departmentNumber",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Dependents_EmployeeSSN",
                table: "Dependents");

            migrationBuilder.DropColumn(
                name: "departmentNumber",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "EmployeeSSN",
                table: "Dependents");

            migrationBuilder.CreateIndex(
                name: "IX_Dependents_ESSN",
                table: "Dependents",
                column: "ESSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Dependents_Employees_ESSN",
                table: "Dependents",
                column: "ESSN",
                principalTable: "Employees",
                principalColumn: "SSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Departments_deptnum",
                table: "Locations",
                column: "deptnum",
                principalTable: "Departments",
                principalColumn: "Number",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependents_Employees_ESSN",
                table: "Dependents");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Departments_deptnum",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Dependents_ESSN",
                table: "Dependents");

            migrationBuilder.AddColumn<int>(
                name: "departmentNumber",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeSSN",
                table: "Dependents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_departmentNumber",
                table: "Locations",
                column: "departmentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Dependents_EmployeeSSN",
                table: "Dependents",
                column: "EmployeeSSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Dependents_Employees_EmployeeSSN",
                table: "Dependents",
                column: "EmployeeSSN",
                principalTable: "Employees",
                principalColumn: "SSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Departments_departmentNumber",
                table: "Locations",
                column: "departmentNumber",
                principalTable: "Departments",
                principalColumn: "Number");
        }
    }
}
