using LibraryManagerBlazor.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerBlazor.Pages
{
	public partial class AuthorDetails
	{

		[Inject]
		private IDbContextFactory<LibraryContext> _contextFactory { get; set; }

		[Parameter]
		public int AuthorId { get; set; }

		private Author _author;

		protected override async Task OnInitializedAsync()
		{
			using var context = _contextFactory.CreateDbContext();
			_author = await context.Authors.Include(a => a.Books).SingleOrDefaultAsync(a => a.AuthorId == AuthorId);
		}
	}
}
