using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerWeb.Migrations
{
    public partial class AddedMoreBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorUrl", "CreationDateUtc", "PublisherId", "Sinopsis", "Title" },
                values: new object[] { 4, "asimov", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Es el libro \"Un guijarro en el cielo\".\".", "Un guijarro en el cielo" });

            migrationBuilder.InsertData(
                table: "BookImages",
                columns: new[] { "BookImageId", "Alt", "BookId", "Caption", "ImageFilePath" },
                values: new object[] { 2, "Una imagen del libro", 4, "text", "img.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "BookImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);
        }
    }
}
