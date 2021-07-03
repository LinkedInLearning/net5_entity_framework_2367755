using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
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

		public DbSet<ProliphicAuthor> ProliphicAuthors { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Author>()
				.HasComment("Tabla para almacenar los autores que tienen libros en la biblioteca.")
				.HasData(new[]
			{
				new Author { AuthorId = 1, Name = "Stephen", LastName = "King" },
				new Author { AuthorId = 2, Name = "Isaac", LastName = "Asimov" }
				});

			modelBuilder.Entity<Publisher>()
				.HasComment("Editoriales")
				.HasData(new[]
			{
				new Publisher { PublisherId = 1, Name = "Entre letras" }
				});

			modelBuilder.Entity<Book>()
				.HasComment("Tabla para almacenar los libros existentes en esta biblioteca.")
				.HasData(new[]
			{
				new Book { BookId = 1, AuthorId = 1, Title = "Los ojos del dragón", Sinopsis = "El libro \"Los ojos del dragón\".", PublisherId = 1 },
				new Book { BookId = 2, AuthorId = 1, Title = "La torre oscura I", Sinopsis = "Es el libro \"La torre oscura I\"." , PublisherId = 1 },
				new Book { BookId = 3, AuthorId = 2, Title = "Yo, robot", Sinopsis = "Es el libro \"Yo, robot\".\"." , PublisherId = 1 }
				});

			modelBuilder.Entity<BookRating>()
				.HasData(new[]
			{
				new BookRating { BookRatingId = 1, BookId = 1, Username = "juanjo", Stars = 5 },
				new BookRating { BookRatingId = 2, BookId = 1, Username = "Lola", Stars = 3 },
				new BookRating { BookRatingId = 3, BookId = 1, Username = "Silvia", Stars = 4 },
				new BookRating { BookRatingId = 4, BookId = 1, Username = "Diego", Stars = 2 },
				new BookRating { BookRatingId = 5, BookId = 2, Username = "juanjo", Stars = 4 },
				new BookRating { BookRatingId = 6, BookId = 2, Username = "Lola", Stars = 2 },
				new BookRating { BookRatingId = 7, BookId = 2, Username = "Silvia", Stars = 5 },
				new BookRating { BookRatingId = 8, BookId = 2, Username = "Diego", Stars = 5 }
				});

			modelBuilder.Entity<RatedBook>()
				.ToView("MostHighlyRatedBooks", schema: "dbo")
				.HasNoKey();

			modelBuilder.Entity<ProliphicAuthor>()
				.ToTable("no-table", t => t.ExcludeFromMigrations())
				.HasNoKey()
				.ToFunction("MostProlificAuthors", opt =>
				{
					opt.HasSchema("dbo");
				});
			base.OnModelCreating(modelBuilder);
		}

		public LibraryContext(DbContextOptions<LibraryContext> options)
			: base(options)
		{
		}
	}
}
