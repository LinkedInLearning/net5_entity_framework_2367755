using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManager.Data.Migrations
{
    public partial class AddedCommentsInSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Publishers",
                comment: "Editoriales");

            migrationBuilder.AlterTable(
                name: "Books",
                comment: "Tabla para almacenar los libros existentes en esta biblioteca.");

            migrationBuilder.AlterTable(
                name: "Authors",
                comment: "Tabla para almacenar los autores que tienen libros en la biblioteca.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Publishers",
                oldComment: "Editoriales");

            migrationBuilder.AlterTable(
                name: "Books",
                oldComment: "Tabla para almacenar los libros existentes en esta biblioteca.");

            migrationBuilder.AlterTable(
                name: "Authors",
                oldComment: "Tabla para almacenar los autores que tienen libros en la biblioteca.");
        }
    }
}
