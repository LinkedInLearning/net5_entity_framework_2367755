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
	[Table("Authors")]
	[Comment("Tabla para almacenar los autores que tienen libros en la biblioteca.")]
	public class Author
	{

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int AuthorId { get; set; }

		[Required]
		[MinLength(3), MaxLength(50)]
		public string Name { get; set; }

		[Required]
		[MinLength(3), MaxLength(100)]
		public string LastName { get; set; }

		public List<Book> Books { get; set; } = new List<Book>();

	}
}
