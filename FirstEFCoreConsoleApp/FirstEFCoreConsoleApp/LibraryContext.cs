using FirstEFCoreConsoleApp.Model;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFCoreConsoleApp
{
	public class LibraryContext : DbContext
	{

		public DbSet<Author> Authors { get; set; }

		public DbSet<Book> Books { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
			optionsBuilder.UseSqlite($"Data Source={Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "library.db")}");
	}
}
