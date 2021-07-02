using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerBlazor.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "LastName", "Name" },
                values: new object[] { 1, "King", "Stephen" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "LastName", "Name" },
                values: new object[] { 2, "Asimov", "Isaac" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "Sinopsis", "Title" },
                values: new object[] { 1, 1, "Se trata del libro \"Los ojos del dragón\".", "Los ojos del dragón" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "Sinopsis", "Title" },
                values: new object[] { 2, 1, "La primera entrega de la saga \"La torre oscura\".", "La torre oscura I" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);
        }
    }
}
