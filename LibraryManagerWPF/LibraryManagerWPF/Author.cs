using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LibraryManagerWPF
{
	public class Author
	{
		public int AuthorId { get; set; }
		
		public string Name { get; set; }

		public string LastName { get; set; }

		public virtual ICollection<Book> Books { get; private set; } = new ObservableCollection<Book>();
	}
}
