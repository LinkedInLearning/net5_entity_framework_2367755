using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerWeb.Migrations
{
    public partial class ChangedColumnTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Stars",
                table: "BookRatings",
                type: "decimal(2,4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(200",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Stars",
                table: "BookRatings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "decimal(2,4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200",
                oldNullable: true);
        }
    }
}
