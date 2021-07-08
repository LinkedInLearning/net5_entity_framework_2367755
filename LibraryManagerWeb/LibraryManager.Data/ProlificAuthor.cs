using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager.Data
{
	public class ProlificAuthor
	{
		public string Name { get; set; }

		public string LastName { get; set; }

		public int BookCount { get; set; }
	}
}