using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerWeb.Migrations
{
    public partial class AddedSomeIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Authors_Name_LastName",
                table: "Authors",
                columns: new[] { "Name", "LastName" });

            migrationBuilder.CreateIndex(
                name: "UX_AuditEntry_ResearchTicketId",
                table: "AuditEntries",
                column: "ResearchTicketId",
                unique: true,
                filter: "[ResearchTicketId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Authors_Name_LastName",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "UX_AuditEntry_ResearchTicketId",
                table: "AuditEntries");
        }
    }
}
