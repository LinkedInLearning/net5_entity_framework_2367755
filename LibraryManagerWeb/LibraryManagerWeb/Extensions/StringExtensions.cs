using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.Extensions
{
	public static class StringExtensions
	{

		public static string Capitalize(this string str)
		{
			if (str is null)
			{
				throw new ArgumentNullException(nameof(str));
			}

			return $"{str.Substring(0, 1).ToUpper()}{str.Substring(1)}";
		}
	}
}