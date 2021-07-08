using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class Publisher
	{

		public int PublisherId { get; set; }

		public string Name { get; set; }

		public virtual List<Book> Books { get; set; }

	}
}
