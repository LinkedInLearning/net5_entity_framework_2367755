using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	[Comment("Editoriales")]
	public class Publisher
	{

		public int PublisherId { get; set; }

		public string Name { get; set; }
	}
}
