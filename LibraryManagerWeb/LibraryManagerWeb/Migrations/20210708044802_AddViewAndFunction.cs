using Microsoft.EntityFrameworkCore.Migrations;

using System.IO;
using System.Reflection;
using System.Text;

namespace LibraryManagerWeb.Migrations
{
    public partial class AddViewAndFunction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("LibraryManagerWeb.DataAccess.SqlFiles.4.4.sql");
			using var reader = new StreamReader(stream, Encoding.UTF8);
			var sqlString = reader.ReadToEnd();
			migrationBuilder.Sql(sqlString);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql("DROP VIEW dbo.MostHighlyRatedBooks;");
			migrationBuilder.Sql("DROP FUNCTION dbo.MostProlificAuthors;");
		}
	}
}
