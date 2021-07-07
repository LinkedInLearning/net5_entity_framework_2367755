using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerWeb.Migrations
{
    public partial class AddedOneToOneRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookImages",
                columns: table => new
                {
                    BookImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Alt = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookImages", x => x.BookImageId);
                    table.ForeignKey(
                        name: "FK_BookImages_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookImages_BookId",
                table: "BookImages",
                column: "BookId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookImages");
        }
    }
}
