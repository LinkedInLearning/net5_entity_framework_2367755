using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class LibraryContext : DbContext
	{

		public DbSet<Author> Authors { get; set; }

		public DbSet<Book> Books { get; set; }

		public DbSet<AuditEntry> AuditEntries { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var phisicalLibrary = modelBuilder.Entity < PhisicalLibrary>();
			modelBuilder.Ignore<Publisher>();

			base.OnModelCreating(modelBuilder);
		}

		public LibraryContext(DbContextOptions<LibraryContext> options)
			: base(options)
		{
		}
	}
}
