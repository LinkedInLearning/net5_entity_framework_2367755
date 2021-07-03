using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class Author
	{

		public int AuthorId { get; set; }

		public string Name { get; set; }

		public string LastName { get; set; }

		public List<Book> Books { get; set; } = new List<Book>();

		[NotMapped]
		public DateTime LoadedDate { get; set; }

	}
}
