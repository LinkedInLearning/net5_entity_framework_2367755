using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager.Data
{
	public class LibraryContext : DbContext
	{
		public DbSet<AuditEntry> AuditEntries { get; set; }

		public DbSet<Author> Authors { get; set; }

		public DbSet<Book> Books { get; set; }

		public DbSet<BookFile> BookFiles { get; set; }

		public DbSet<BookFormat> BookFormats { get; set; }

		public DbSet<BookRating> BookRatings { get; set; }

		public DbSet<Country> Countries { get; set; }

		public DbSet<Publisher> Publishers { get; set; }

		public DbSet<RatedBook> MostHighlyRatedBooks { get; set; }

		public DbSet<ProlificAuthor> ProliphicAuthors { get; set; }

		public DbSet<Tag> Tags { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryContext).Assembly);
			base.OnModelCreating(modelBuilder);
		}


		public LibraryContext(DbContextOptions<LibraryContext> options)
			: base(options)
		{
		}
	}
}
