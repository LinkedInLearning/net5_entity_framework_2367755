using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess.EntityConfig
{
	public class BookRatingConfig : IEntityTypeConfiguration<BookRating>
	{
		public void Configure(EntityTypeBuilder<BookRating> bookRatingBuilder)
		{
			bookRatingBuilder.Property(p => p.Stars).HasDefaultValue(3);
			bookRatingBuilder.HasData(new[]
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
		}
	}
}
