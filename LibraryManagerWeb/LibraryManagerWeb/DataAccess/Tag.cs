using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class Tag
	{

		public int TagId { get; set; }

		public string Value { get; set; }

		public List<Book> Books { get; set; }
	}
}
