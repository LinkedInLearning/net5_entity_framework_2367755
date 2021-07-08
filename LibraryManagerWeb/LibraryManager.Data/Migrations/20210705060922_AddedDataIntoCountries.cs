using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManager.Data.Migrations
{
    public partial class AddedDataIntoCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "EnglishName", "NativeName" },
                values: new object[] { 1, "Spain", "España" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1);
        }
    }
}
