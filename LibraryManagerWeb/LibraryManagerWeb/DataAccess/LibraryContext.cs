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

		public DbSet<BookFile> BookFiles { get; set; }

		public DbSet<Publisher> Publishers { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Country>()
				.ToTable("Countries");
			base.OnModelCreating(modelBuilder);
		}

		public LibraryContext(DbContextOptions<LibraryContext> options)
			: base(options)
		{
		}
	}
}
