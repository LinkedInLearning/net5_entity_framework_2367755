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
			var authorEntity = modelBuilder.Entity<Author>();
			authorEntity.HasMany(p => p.Books)
				.WithOne(b => b.Author)
				.HasForeignKey(p => p.AuthorUrl)
				.HasPrincipalKey(p => p.AuthorUrl);
			authorEntity.HasData(new[]
			{
				new Author { AuthorId = 1, Name = "Stephen", LastName = "King", AuthorUrl = "stephenking" },
				new Author { AuthorId = 2, Name = "Isaac", LastName = "Asimov", AuthorUrl = "asimov" }
				});

			var publisherEntity = modelBuilder.Entity<Publisher>();
			publisherEntity.Property(p => p.Name).HasColumnName("PublisherName");
			publisherEntity.Property(p => p.Name).HasComment("El nombre de la editorial");

			publisherEntity.HasData(new[]
		{
				new Publisher { PublisherId = 1, Name = "Entre letras" }
				});

			var bookEntity = modelBuilder.Entity<Book>();
			bookEntity.HasKey(p => p.BookId)
				.HasName("PK_MyBooks");

			bookEntity.Ignore(p => p.LoadedDate)
			.Property(p => p.Title).HasMaxLength(300);

			bookEntity.Property(p => p.Title)
				.UseCollation("SQL_Latin1_General_CP1_CI_AI");

			bookEntity.HasData(new[]
		{
				new Book { BookId = 1, AuthorUrl = "stephenking", Title = "Los ojos del dragón", Sinopsis = "El libro \"Los ojos del dragón\".", PublisherId = 1 },
				new Book { BookId = 2, AuthorUrl= "stephenking", Title = "La torre oscura I", Sinopsis = "Es el libro \"La torre oscura I\"." , PublisherId = 1 },
				new Book { BookId = 3, AuthorUrl= "asimov", Title = "Yo, robot", Sinopsis = "Es el libro \"Yo, robot\".\"." , PublisherId = 1 }
				});

			var bookRatingEntity = modelBuilder.Entity<BookRating>();
			bookRatingEntity.HasData(new[]
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
				.ToView("MostHighlyRatedBooks", schema: "dbo");

			modelBuilder.Entity<ProliphicAuthor>()
				.ToTable("no-table", t => t.ExcludeFromMigrations())
				.ToFunction("MostProlificAuthors", opt =>
				{
					opt.HasSchema("dbo");
				});


			var auditEntryEntity = modelBuilder.Entity<AuditEntry>();

			auditEntryEntity.Property(p => p.TimeSpent)
				.HasPrecision(20);

			auditEntryEntity.Property(p => p.IpAddress).IsRequired();

			base.OnModelCreating(modelBuilder);
		}

		public LibraryContext(DbContextOptions<LibraryContext> options)
			: base(options)
		{
		}
	}
}
