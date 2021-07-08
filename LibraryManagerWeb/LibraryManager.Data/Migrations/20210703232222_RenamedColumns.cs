using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManager.Data.Migrations
{
    public partial class RenamedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Publishers",
                newName: "PublisherName");

            migrationBuilder.RenameColumn(
                name: "InternalFilePath",
                table: "BookFiles",
                newName: "FilePath");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublisherName",
                table: "Publishers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FilePath",
                table: "BookFiles",
                newName: "InternalFilePath");
        }
    }
}
