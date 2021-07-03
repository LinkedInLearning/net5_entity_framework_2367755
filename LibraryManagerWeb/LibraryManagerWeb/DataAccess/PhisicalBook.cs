using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class PhisicalBook
	{

		public int PhisicalBookId { get; set; }

		public int PhisicalLibraryId { get; set; }

		public PhisicalLibrary Library { get; set; }

		public string Title { get; set; }

		public int AuthorId { get; set; }

		public Author Author { get; set; }

	}
}
