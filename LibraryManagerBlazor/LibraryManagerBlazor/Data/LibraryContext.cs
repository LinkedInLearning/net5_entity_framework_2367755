using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerBlazor.Data
{
	public class LibraryContext : DbContext
	{

		public DbSet<Author> Authors { get; set; }

		public DbSet<Book> Books { get; set; }


		public LibraryContext(DbContextOptions<LibraryContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var author = modelBuilder.Entity<Author>();
			author.HasData(new[] {
				new Author { AuthorId = 1, Name = "Stephen", LastName = "King" },
				new Author { AuthorId = 2, Name = "Isaac", LastName = "Asimov" },
			});

			var book = modelBuilder.Entity<Book>();
			book.HasData(new[]
			{
				new Book { BookId = 1, AuthorId = 1, Title = "Los ojos del dragón", Sinopsis = "Se trata del libro \"Los ojos del dragón\"." },
				new Book { BookId = 2, AuthorId = 1, Title = "La torre oscura I", Sinopsis = "La primera entrega de la saga \"La torre oscura\"." }
				});

			base.OnModelCreating(modelBuilder);
		}
	}
}
