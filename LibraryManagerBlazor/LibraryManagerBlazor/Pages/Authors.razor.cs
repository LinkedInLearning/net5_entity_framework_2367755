using LibraryManagerBlazor.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerBlazor.Pages
{
	public partial class Authors
	{

		[Inject]
		private IDbContextFactory<LibraryContext> _contextFactory { get; set; }

		private List<Author> _authors;

		protected override async Task OnInitializedAsync()
		{
			using var context = _contextFactory.CreateDbContext();
			_authors = await context.Authors.OrderBy(a => a.Name).ThenBy(a => a.LastName).ToListAsync();
		}
	}
}
