using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager.Data.EntityConfig
{
	public class PublisherConfig : IEntityTypeConfiguration<Publisher>
	{
		public void Configure(EntityTypeBuilder<Publisher> publisherBuilder)
		{
			publisherBuilder.HasComment("Editoriales");
			publisherBuilder.Property(p => p.Name).HasColumnName("PublisherName");
			publisherBuilder.Property(p => p.Name).HasComment("El nombre de la editorial");

			publisherBuilder.HasData(new[]
			{
				new Publisher { PublisherId = 1, Name = "Entre letras" }
				});
		}
	}
}
