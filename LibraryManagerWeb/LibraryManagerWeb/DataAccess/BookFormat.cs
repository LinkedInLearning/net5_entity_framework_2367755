using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class BookFormat
	{

		public int BookFormatId { get; set; }

		public string Name { get; set; }
	}
}
