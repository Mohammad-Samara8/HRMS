using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMS.Migrations
{
    /// <inheritdoc />
    public partial class relationship_managerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_EmployeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeId",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ManagerId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees");

            migrationBuilder.AddColumn<long>(
                name: "EmployeId",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeId",
                table: "Employees",
                column: "EmployeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_EmployeId",
                table: "Employees",
                column: "EmployeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
