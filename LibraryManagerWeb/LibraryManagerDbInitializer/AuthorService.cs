using LibraryManager.Data;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDbInitializer
{
	public class AuthorService
	{

		public IEnumerable<Author> GetAuthors()
		{
			using var fileStream = File.OpenRead(Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "Files", "books.csv"));
			using var reader = new StreamReader(fileStream ,Encoding.UTF8);

			// Saltamos la primera línea de cabeceras.
			reader.ReadLine();
			string line = null;

			do
			{
				line = reader.ReadLine();
				if (line != null)
				{
					var fields = line.Split(new[] { ',' }, StringSplitOptions.None);
					var author = fields[2];
					var authorEntity = GetAuthorEntity(author);
					yield return authorEntity;
				}
			} while (line != null);
		}

		private Author GetAuthorEntity(string authorStr)
		{
			var firstAuthor = authorStr.Split(new[] { '/' }, StringSplitOptions.None).First();
			var words = firstAuthor.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var name = words[0];
			var lastName = string.Join(" ", words.Skip(1));
			return new Author { Name = name, LastName = lastName, AuthorUrl = $"{name}_{lastName}_{Guid.NewGuid()}".ToLower() };
		}


	}
}
