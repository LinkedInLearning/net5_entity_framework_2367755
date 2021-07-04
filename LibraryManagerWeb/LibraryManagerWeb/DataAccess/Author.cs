using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	[Comment("Tabla para almacenar los autores que tienen libros en la biblioteca.")]
	public class Author
	{

		[Key]
		public int AuthorId { get; set; }

		[MaxLength(100)]
		public string Name { get; set; }

		[MaxLength(200)]
		public string LastName { get; set; }

		public string AuthorUrl { get; set; }

		public List<Book> Books { get; set; } = new List<Book>();

		[NotMapped]
		public DateTime LoadedDate { get; set; }

	}
}
