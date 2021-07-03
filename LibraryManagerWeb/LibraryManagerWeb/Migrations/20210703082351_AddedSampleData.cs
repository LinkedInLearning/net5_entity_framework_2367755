using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerWeb.Migrations
{
    public partial class AddedSampleData : Migration
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
                table: "Publishers",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 1, "Entre letras" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "PublisherId", "Sinopsis", "Title" },
                values: new object[] { 1, 1, 1, "El libro \"Los ojos del dragón\".", "Los ojos del dragón" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "PublisherId", "Sinopsis", "Title" },
                values: new object[] { 2, 1, 1, "Es el libro \"La torre oscura I\".", "La torre oscura I" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "PublisherId", "Sinopsis", "Title" },
                values: new object[] { 3, 2, 1, "Es el libro \"Yo, robot\".\".", "Yo, robot" });

            migrationBuilder.InsertData(
                table: "BookRatings",
                columns: new[] { "BookRatingId", "BookId", "Stars", "Username" },
                values: new object[,]
                {
                    { 1, 1, 5, "juanjo" },
                    { 2, 1, 3, "Lola" },
                    { 3, 1, 4, "Silvia" },
                    { 4, 1, 2, "Diego" },
                    { 5, 2, 4, "juanjo" },
                    { 6, 2, 2, "Lola" },
                    { 7, 2, 5, "Silvia" },
                    { 8, 2, 5, "Diego" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRatingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRatingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRatingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRatingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRatingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRatingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRatingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookRatings",
                keyColumn: "BookRatingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

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

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 1);
        }
    }
}
