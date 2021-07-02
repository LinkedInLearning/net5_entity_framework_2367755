using FirstEFCoreConsoleApp.Model;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEFCoreConsoleApp
{
	class Program
	{

		static async Task<int> Main(string[] args)
		{
			try
			{
				using var context = new LibraryContext();
				var authors = new[]
				{
					new Author { Name = "Robert", LastName = "Cecil Martin" },
					new Author { Name = "Martin", LastName = "Fowler" }
				};
				
				var tasks = new List<Task>();
				for (var i = 0; i < authors.Length; i++)
				{
					var author = authors[i];
					tasks.Add(Task.Run(async () =>
					{
						await context.AddAsync(author);
						await context.SaveChangesAsync();
						context.Authors.Remove(author);
						await context.SaveChangesAsync();
					}));
				}
				await Task.WhenAll(tasks);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return 0;
		}
	}
}