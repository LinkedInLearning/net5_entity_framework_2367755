using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess.EntityConfig
{
	public class BookFormatConfig : IEntityTypeConfiguration<BookFormat>
	{
		
		public void Configure(EntityTypeBuilder<BookFormat> bookFormatBuilder)
		{
			bookFormatBuilder.HasData(new[] {
				new BookFormat { BookFormatId = 1, Name = "RTF" },
				new BookFormat { BookFormatId = 2, Name = "Microsoft Word" },
				new BookFormat { BookFormatId = 3, Name = "Epub" }
			});
		}
	}
}
