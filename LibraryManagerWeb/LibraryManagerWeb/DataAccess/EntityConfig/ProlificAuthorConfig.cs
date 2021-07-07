using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess.EntityConfig
{
	public class ProlificAuthorConfig : IEntityTypeConfiguration<ProlificAuthor>
	{
		public void Configure(EntityTypeBuilder<ProlificAuthor> builder)
		{
			builder.ToTable("no-table", t => t.ExcludeFromMigrations())
				.ToFunction("MostProlificAuthors", opt =>
				{
					opt.HasSchema("dbo");
				});
		}
	}
}
