using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class BookImage
	{

		public int BookImageId { get; set; }

		public int BookId { get; set; }

		public virtual Book Book { get; set; }

		public string Caption { get; set; }

		public string Alt { get; set; }

		public string ImageFilePath { get; set; }
	}
}
