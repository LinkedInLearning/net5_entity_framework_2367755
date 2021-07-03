using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class BookFile
	{

		public int BookFileId { get; set; }

		public int BookId { get; set; }

		public Book Book { get; set; }

		[Column("FilePath")]
		public string InternalFilePath { get; set; }

		public int BookFormatId { get; set; }

		public BookFormat Format	 { get; set; }
	}
}
