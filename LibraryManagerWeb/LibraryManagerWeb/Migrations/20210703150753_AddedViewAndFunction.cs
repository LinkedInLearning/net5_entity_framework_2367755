using Microsoft.EntityFrameworkCore.Migrations;

using System.IO;
using System.Reflection;
using System.Text;

namespace LibraryManagerWeb.Migrations
{
	public partial class AddedViewAndFunction : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("LibraryManagerWeb.DataAccess.SqlFiles.4.4.sql");
			using var reader = new BinaryReader(stream);
			var bytes = reader.ReadBytes((int)stream.Length);
			var sqlString = Encoding.UTF8.GetString(bytes);

			migrationBuilder.Sql(sqlString);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql("DROP VIEW dbo.MostHighlyRatedBooks;");
			migrationBuilder.Sql("DROP FUNCTION dbo.MostProlificAuthors;");
		}
	}
}
