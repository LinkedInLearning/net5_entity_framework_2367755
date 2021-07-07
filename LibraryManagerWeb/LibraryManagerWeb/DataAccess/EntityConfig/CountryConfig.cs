using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess.EntityConfig
{
	public class CountryConfig : IEntityTypeConfiguration<Country>
	{
		public void Configure(EntityTypeBuilder<Country> countryBuilder)
		{
			countryBuilder.HasData(new[] {
				new Country { CountryId = 1, NativeName = "España", EnglishName = "Spain" }
			});
		}
	}
}
