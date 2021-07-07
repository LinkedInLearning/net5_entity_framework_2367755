using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerWeb.Migrations
{
    public partial class AddedDataInBookImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookImages",
                columns: new[] { "BookImageId", "Alt", "BookId", "Caption", "ImageFilePath" },
                values: new object[] { 1, "Una imagen del libro", 1, "text", "img.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "BookImageId",
                keyValue: 1);
        }
    }
}
