
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Model
{
	public class DesignTimeLibraryContextFactory : IDesignTimeDbContextFactory<LibraryContext>
	{
		public LibraryContext CreateDbContext(string[] args)
		{
			var options = new DbContextOptionsBuilder<LibraryContext>();
			var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LibraryManager", "library.db");
			var dbDir = Path.GetDirectoryName(dbPath);
			if (!Directory.Exists(dbDir))
			{
				Directory.CreateDirectory(dbDir);
			}
			options.UseSqlite($"Data Source={dbPath}");
			return new LibraryContext(options.Options);
		}
	}
}
