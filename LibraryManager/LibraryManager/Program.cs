using LibraryManager.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager
{
	class Program
	{
		private static LibraryContext _context;

		static async Task<int> Main(string[] args)
		{
			var serviceProvider = new ServiceCollection()
				.AddDbContext<LibraryContext>(options =>
			{
				var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LibraryManager", "library.db");
				var dbDir = Path.GetDirectoryName(dbPath);
				if (!Directory.Exists(dbDir))
				{
					Directory.CreateDirectory(dbDir);
				}
				options.UseSqlite($"Data Source={dbPath}");
			}, ServiceLifetime.Transient, ServiceLifetime.Transient)
				.BuildServiceProvider();

			_context = serviceProvider.GetRequiredService<LibraryContext>();

			var exit = false;

			while (!exit)
			{
				ShowMainMenu();
				var choice = ReadMenuOption();
				switch (choice)
				{
					case 3:
						exit = true;
						break;
					case 1:
						await ManageAuthorsAsync();
						break;
					case 2:
						await ManageBooksAsync();
						break;
					default:
						Console.WriteLine("Opción incorrecta.");
						break;
				}
			}
			await _context.DisposeAsync();
			return 0;
		}

		private static void ShowMainMenu()
		{
			Console.WriteLine("1. Autores." + Environment.NewLine +
				"2. Libros." + Environment.NewLine +
				"3. Salir.");
		}

		private static int ReadMenuOption()
		{
			var choice = Console.ReadLine();
			int choiceNumber = 0;
			while (!Int32.TryParse(choice, out choiceNumber))
			{
				Console.WriteLine("Debes especificar un valor numérico.");
			}
			return choiceNumber;
		}

		private static async Task ManageAuthorsAsync()
		{
			var exit = false;
			while (!exit)
			{
				Console.WriteLine(@"Menú de autores:
1. Lista de autores.
2. Añadir autor.
3. Eliminar autor.
4. Volver.");
				var choice = ReadMenuOption();
				switch (choice)
				{
					case 4:
						exit = true;
						break;
					case 1:
						await ShowAuthorsAsync();
						break;
					case 2:
					case 3:
						Console.WriteLine("NO implementado.");
						break;
				}
			}
		}

		private static async Task ShowAuthorsAsync()
		{
			var authors = await _context.Authors.ToListAsync();
			PrintRow(100, "Nombre", "Apellidos");
			PrintLine(100);
			foreach (var author in authors)
			{
				PrintRow(100, author.Name, author.LastName);
			}
			PrintLine(100);
		}

		private static async Task ManageBooksAsync()
		{
			Console.WriteLine("No implementado.");
		}


		private static void PrintLine(int tableWidth)
		{
			Console.WriteLine(new string('-', tableWidth));
		}

		private static void PrintRow(int tableWidth, params string[] columns)
		{
			int width = (tableWidth - columns.Length) / columns.Length;
			string row = "|";

			foreach (string column in columns)
			{
				row += AlignCentre(column, width) + "|";
			}

			Console.WriteLine(row);
		}

		private static string AlignCentre(string text, int width)
		{
			text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

			if (string.IsNullOrEmpty(text))
			{
				return new string(' ', width);
			}
			else
			{
				return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
			}
		}
	}
}
