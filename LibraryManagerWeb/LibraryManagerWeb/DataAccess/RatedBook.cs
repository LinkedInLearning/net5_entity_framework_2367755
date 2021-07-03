using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class RatedBook
	{

		public int BookId { get; set; }

		public string Title { get; set; }

		public string Name { get; set; }

		public string LastName { get; set; }

		public decimal Stars { get; set; }

	}
}