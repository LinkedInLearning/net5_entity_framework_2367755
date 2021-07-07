using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess.EntityConfig
{
	public class TagConfig : IEntityTypeConfiguration<Tag>
	{
		public void Configure(EntityTypeBuilder<Tag> tagBuilder)
		{
			tagBuilder.ToTable("Tags");
			tagBuilder.Property(p => p.Value).IsRequired()
				.HasMaxLength(100);
		}
	}
}
