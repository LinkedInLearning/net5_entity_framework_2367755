using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Data
{
	public class Book
	{

		public int BookId { get; set; }

		public string AuthorUrl { get; set; }

		public Author Author { get; set; }

		public string Title { get; set; }

		public string Sinopsis { get; set; }

		public DateTime CreationDateUtc { get; set; }

		public DateTime LoadedDate { get; set; }

		public List<BookFile> BookFiles { get; set; }

		public Publisher Publisher { get; set; }

		public BookImage BookImage { get; set; }

		public List<Tag> Tags { get; set; }

		public List<BookRating> Ratings { get; set; }
	}
}
