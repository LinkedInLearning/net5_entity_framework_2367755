using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class Country
	{

		[Comment("Clave primaria de la tabla de países.")]
		public int CountryId { get; set; }

		public string NativeName { get; set; }

		public string EnglishName { get; set; }
	}
}
