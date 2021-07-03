using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	[Keyless]
	public class RatedBook
	{

		public int BookId { get; set; }

		public string Title { get; set; }

		public string Name { get; set; }

		public string LastName { get; set; }

		public double Stars { get; set; }

	}
}