using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManager.Data.Migrations
{
    public partial class ChangedAuthorBookRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "AuthorUrl",
                table: "Books",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorUrl",
                table: "Authors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Authors_AuthorUrl",
                table: "Authors",
                column: "AuthorUrl");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorUrl", "LastName", "Name" },
                values: new object[] { 2, "asimov", "Asimov", "Isaac" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorUrl", "LastName", "Name" },
                values: new object[] { 1, "stephenking", "King", "Stephen" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "AuthorUrl",
                value: "stephenking");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "AuthorUrl",
                value: "stephenking");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "AuthorUrl",
                value: "asimov");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorUrl",
                table: "Books",
                column: "AuthorUrl");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorUrl",
                table: "Books",
                column: "AuthorUrl",
                principalTable: "Authors",
                principalColumn: "AuthorUrl",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorUrl",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorUrl",
                table: "Books");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Authors_AuthorUrl",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "AuthorUrl",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "AuthorUrl",
                table: "Authors");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "AuthorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "AuthorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "AuthorId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
