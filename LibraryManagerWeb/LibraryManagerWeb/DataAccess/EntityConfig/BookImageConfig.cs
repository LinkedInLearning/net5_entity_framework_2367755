using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess.EntityConfig
{
	public class BookImageConfig : IEntityTypeConfiguration<BookImage>
	{
		public void Configure(EntityTypeBuilder<BookImage> bookImageBuilder)
		{
			bookImageBuilder.Property(p => p.Caption).HasMaxLength(500);
			bookImageBuilder.Property(p => p.Alt).HasMaxLength(1000)
				.IsRequired();

			bookImageBuilder.HasOne(p => p.Book)
				.WithOne(p => p.BookImage)
				.IsRequired();

			bookImageBuilder.ToTable("BookImages");

			bookImageBuilder.HasData(new[]
			{
				new BookImage { BookImageId = 1, BookId = 1, ImageFilePath = "img.jpg", Caption = "text", Alt = "Una imagen del libro" },
				new BookImage { BookImageId = 2, BookId = 4, ImageFilePath = "img.jpg", Caption = "text", Alt = "Una imagen del libro" }
			});
		}
	}
}
