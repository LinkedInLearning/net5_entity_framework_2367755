using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class BookRating
	{
		public int BookRatingId { get; set; }

		public int BookId { get; set; }

		public Book Book { get; set; }

		public string Username { get; set; }
		
		public ushort Stars { get; set; }
	}
}
