using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerWeb.Migrations
{
    public partial class AddedMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookformatId",
                table: "BookFormats",
                newName: "BookFormatId");

            migrationBuilder.InsertData(
                table: "BookFormats",
                columns: new[] { "BookFormatId", "Name" },
                values: new object[] { 1, "RTF" });

            migrationBuilder.InsertData(
                table: "BookFormats",
                columns: new[] { "BookFormatId", "Name" },
                values: new object[] { 2, "Microsoft Word" });

            migrationBuilder.InsertData(
                table: "BookFormats",
                columns: new[] { "BookFormatId", "Name" },
                values: new object[] { 3, "Epub" });

            migrationBuilder.InsertData(
                table: "BookFiles",
                columns: new[] { "BookFileId", "BookFormatId", "BookId", "FilePath" },
                values: new object[,]
                {
                    { 1, 1, 1, "ojos.rtf" },
                    { 4, 1, 2, "torre.rtf" },
                    { 2, 2, 1, "ojos.docx" },
                    { 5, 2, 2, "torre.docx" },
                    { 3, 3, 1, "ojos.epub" },
                    { 6, 3, 2, "torre.epub" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookFiles",
                keyColumn: "BookFileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookFiles",
                keyColumn: "BookFileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookFiles",
                keyColumn: "BookFileId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookFiles",
                keyColumn: "BookFileId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookFiles",
                keyColumn: "BookFileId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookFiles",
                keyColumn: "BookFileId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookFormats",
                keyColumn: "BookFormatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookFormats",
                keyColumn: "BookFormatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookFormats",
                keyColumn: "BookFormatId",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "BookFormatId",
                table: "BookFormats",
                newName: "BookformatId");
        }
    }
}
