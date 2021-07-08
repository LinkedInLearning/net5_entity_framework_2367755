using EFCore.BulkExtensions;

using LibraryManager.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using System;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerDbInitializer
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var config = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.Build();
			var connectionString = config.GetConnectionString("DefaultConnection");

			using var context = new LibraryContext(
				new DbContextOptionsBuilder<LibraryContext>().UseSqlServer(connectionString).Options);
			var authors = new AuthorService().GetAuthors().ToList();
			context.BulkInsertOrUpdate(authors);
		}
	}
}
