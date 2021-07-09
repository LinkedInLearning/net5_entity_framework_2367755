using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess.EntityConfig
{
	public class BookConfig : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> bookBuilder)
		{
			bookBuilder.HasComment("Tabla para almacenar los libros existentes en esta biblioteca.");
			bookBuilder.HasKey(p => p.BookId);

			bookBuilder.Property(p => p.CreationDateUtc).HasDefaultValueSql("getutcdate()");
			bookBuilder.Ignore(p => p.LoadedDate)
			.Property(p => p.Title).HasMaxLength(300);

			bookBuilder.Property(p => p.Title)
				.UseCollation("SQL_Latin1_General_CP1_CI_AI");

			bookBuilder.HasOne(p => p.Publisher)
				.WithMany(p => p.Books)
				.IsRequired();
			bookBuilder.HasMany(p => p.Tags)
							.WithMany(p => p.Books);


			bookBuilder.HasData(new[]
			{
				new Book { BookId = 1, AuthorUrl = "stephenking", Title = "Los ojos del dragón", Sinopsis = "El libro \"Los ojos del dragón\".", PublisherId = 1, CreationDateUtc = new DateTime(2021, 1, 1, 0, 0, 0) },
				new Book { BookId = 2, AuthorUrl= "stephenking", Title = "La torre oscura I", Sinopsis = "Es el libro \"La torre oscura I\"." , PublisherId = 1 , CreationDateUtc = new DateTime(2021, 1, 1, 0, 0, 0) },
				new Book { BookId = 3, AuthorUrl= "asimov", Title = "Yo, robot", Sinopsis = "Es el libro \"Yo, robot\".\"." , PublisherId = 1 , CreationDateUtc = new DateTime(2021, 1, 1, 0, 0, 0) },
				new Book { BookId = 4, AuthorUrl= "asimov", Title = "Un guijarro en el cielo", Sinopsis = "Es el libro \"Un guijarro en el cielo\".\"." , PublisherId = 1 , CreationDateUtc = new DateTime(2021, 1, 1, 0, 0, 0) }
				});
		}
	}
}
