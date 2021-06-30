using EFCoreReverseEngineering.Model;

using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreReverseEngineering
{
	class Program
	{
		static async Task Main(string[] args)
		{
			using var context = new LibraryContext();
			var author = new Author { FirstName = "Stephen", LastName = "King" };
			var book = new Book { Title = "Los ojos del dragón", Author = author, Sinopsis = "Esta es la sinopsis del libro." };
			context.Authors.Add(author);
			context.Books.Add(book);
			await context.SaveChangesAsync();
			var bookFromDb = context.Books.FirstOrDefault(b => b.Title == "Los ojos del dragón");
			if (bookFromDb != null)
			{
				context.Books.Remove(bookFromDb);
			}
			var authorFromDb = context.Authors.FirstOrDefault(a => a.FirstName == "Stephen");
			if (authorFromDb != null)
			{
				context.Authors.Remove(authorFromDb);
			}
			await context.SaveChangesAsync();
		}
	}
}
