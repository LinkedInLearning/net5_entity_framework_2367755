using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManager.Data.Migrations
{
    public partial class ChangedPrecission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TimeSpent",
                table: "AuditEntries",
                type: "decimal(20,2)",
                precision: 20,
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeSpent",
                table: "AuditEntries");
        }
    }
}
