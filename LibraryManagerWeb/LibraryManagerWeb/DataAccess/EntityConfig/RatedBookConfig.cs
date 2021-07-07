using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess.EntityConfig
{
	public class RatedBookConfig : IEntityTypeConfiguration<RatedBook>
	{
		public void Configure(EntityTypeBuilder<RatedBook> ratedBookBuilder)
		{
			ratedBookBuilder.HasNoKey();
			ratedBookBuilder.ToView("MostHighlyRatedBooks", schema: "dbo");
		}
	}
}
