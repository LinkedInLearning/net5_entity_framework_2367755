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

		public DbSet<PhisicalLibrary> PhisicalLibraries { get; set; }

		public DbSet<PhisicalBook> PhisicalBooks { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<PhisicalLibrary>()
				.ToTable("PhisicalLibraries", t => t.ExcludeFromMigrations());

			modelBuilder.Entity<PhisicalBook>()
				.ToTable("PhisicalBooks", t => t.ExcludeFromMigrations());

			base.OnModelCreating(modelBuilder);
		}

		public LibraryContext(DbContextOptions<LibraryContext> options)
			: base(options)
		{
		}
	}
}
