using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class Book
	{

		public int BookId { get; set; }

		public string AuthorUrl { get; set; }

		public virtual Author Author { get; set; }

		public string Title { get; set; }

		public string Sinopsis { get; set; }

		public DateTime CreationDateUtc { get; set; }

		public DateTime LoadedDate { get; set; }

		public virtual List<BookFile> BookFiles { get; set; }

		public int PublisherId { get; set; }

		public virtual Publisher Publisher { get; set; }

		public virtual BookImage BookImage { get; set; }

		public virtual List<Tag> Tags { get; set; }

		public virtual List<BookRating> Ratings { get; set; }
	
	}
}
