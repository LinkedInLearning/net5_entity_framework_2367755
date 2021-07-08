using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager.Data
{
	public class BookFormat
	{

		public int BookformatId { get; set; }

		public string Name { get; set; }
	}
}
