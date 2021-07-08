using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager.Data
{
	public class Publisher
	{

		public int PublisherId { get; set; }

		public string Name { get; set; }

		public List<Book> Books { get; set; }

	}
}
