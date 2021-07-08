using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess.EntityConfig
{
	public class BookFileConfig : IEntityTypeConfiguration<BookFile>
	{
		public void Configure(EntityTypeBuilder<BookFile> bookFileBuilder)
		{
			bookFileBuilder.HasData(new[] {
				new BookFile { BookFileId = 1, BookId = 1, BookFormatId = 1, InternalFilePath = "ojos.rtf" },
				new BookFile { BookFileId = 2, BookId = 1, BookFormatId = 2, InternalFilePath = "ojos.docx" },
				new BookFile { BookFileId = 3, BookId = 1, BookFormatId = 3, InternalFilePath = "ojos.epub" },
				new BookFile { BookFileId = 4, BookId = 2, BookFormatId = 1, InternalFilePath = "torre.rtf" },
				new BookFile { BookFileId = 5, BookId = 2, BookFormatId = 2, InternalFilePath = "torre.docx" },
				new BookFile { BookFileId = 6, BookId = 2, BookFormatId = 3, InternalFilePath = "torre.epub" },
			});
		}
	}
}
