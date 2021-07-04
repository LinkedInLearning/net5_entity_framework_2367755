using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	[Comment("Tabla para almacenar los libros existentes en esta biblioteca.")]
	public class Book
	{

		public int BookId { get; set; }

		public string AuthorUrl { get; set; }

		public Author Author { get; set; }

		public string Title { get; set; }

		public string Sinopsis { get; set; }

		public DateTime LoadedDate { get; set; }

		public List<BookFile> BookFiles { get; set; }

		public int PublisherId { get; set; }

		public Publisher Publisher { get; set; }

		public List<BookRating> Ratings { get; set; }

	}
}
