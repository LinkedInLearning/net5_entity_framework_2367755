using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class Category
	{

		public int CategoryId { get; set; }

		public string Name { get; set; }

		public int Level { get; set; }

		public int? ParentCategoryId { get; set; }

		public Category Parent { get; set; }

		public List<Category> Children { get; set; }

	}
}
