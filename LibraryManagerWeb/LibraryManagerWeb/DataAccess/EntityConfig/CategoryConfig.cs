using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess.EntityConfig
{
	public class CategoryConfig : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> categoryBuilder)
		{
			categoryBuilder.HasOne(p => p.Parent)
	.WithMany(p => p.Children)
	.HasForeignKey(p => p.ParentCategoryId)
	.HasPrincipalKey(p => p.CategoryId);

			categoryBuilder.Property(p => p.Name)
				.HasMaxLength(50)
				.IsRequired();

			categoryBuilder.HasData(new[]
			{
				new Category { CategoryId = 1, Name = "Disciplinas", Level = 1 },
				new Category { CategoryId = 2, Name = "Animales, hogar y plantas", Level = 2, ParentCategoryId = 1 },
				new Category { CategoryId = 3, Name = "Antropología", Level = 2, ParentCategoryId = 1 },
				new Category { CategoryId = 4, Name = "Arte", Level = 2, ParentCategoryId = 1 },
				new Category { CategoryId = 5, Name = "Ciencias naturales y biología", Level = 2, ParentCategoryId = 1 },
				new Category { CategoryId = 6, Name = "Ensayos", Level = 1 },
				new Category { CategoryId = 7, Name = "Autoayuda y desarrollo personal", Level = 2, ParentCategoryId = 6 },
				new Category { CategoryId = 8, Name = "Ciencias", Level = 2, ParentCategoryId = 6 },
				new Category { CategoryId = 9, Name = "Historia y ciencias sociales", Level = 2, ParentCategoryId = 6 },
				new Category { CategoryId = 10, Name = "Filosofía y religión", Level = 2, ParentCategoryId = 6 },
				new Category { CategoryId = 11, Name = "Literatura", Level = 1 },
				new Category { CategoryId = 12, Name = "Biografías, viajes y testimonios", Level = 2, ParentCategoryId = 11 },
				new Category { CategoryId = 13, Name = "Ciencia ficción y fantasía", Level = 2, ParentCategoryId = 11 },
				new Category { CategoryId = 14, Name = "Cuentos y relatos", Level = 2, ParentCategoryId = 11 },
				new Category { CategoryId = 15, Name = "Fábulas y leyendas", Level = 2, ParentCategoryId = 11 },
			});
		}
	}
}
