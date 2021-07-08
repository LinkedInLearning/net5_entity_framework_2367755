using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManager.Data.EntityConfig
{
	public class AuthorConfig : IEntityTypeConfiguration<Author>
	{
		public void Configure(EntityTypeBuilder<Author> authorBuilder)
		{
			authorBuilder.HasIndex(p => new { p.Name, p.LastName });
			authorBuilder.HasKey(p => p.AuthorId);
			authorBuilder.Property(p => p.Name).HasMaxLength(100);
			authorBuilder.Property(p => p.LastName).HasMaxLength(200);
			authorBuilder.Ignore(p => p.LoadedDate);
			authorBuilder.Property(p => p.AuthorId).ValueGeneratedOnAdd();
			authorBuilder.Property(p => p.DisplayName).HasComputedColumnSql("Name + ' ' + LastName", stored: true);
			authorBuilder.HasMany<Book>()
				.WithOne(b => b.Author)
				.HasForeignKey(p => p.AuthorUrl)
				.HasPrincipalKey(p => p.AuthorUrl)
				.IsRequired();

			authorBuilder.HasData(new[]
			{
				new Author { AuthorId = 1, Name = "Stephen", LastName = "King", AuthorUrl = "stephenking" },
				new Author { AuthorId = 2, Name = "Isaac", LastName = "Asimov", AuthorUrl = "asimov" }
				});
		}
	}
}
