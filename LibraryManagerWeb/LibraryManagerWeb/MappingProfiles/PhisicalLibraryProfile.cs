using AutoMapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.MappingProfiles
{
	public class PhisicalLibraryProfile : Profile
	{

		public PhisicalLibraryProfile()
		{
			CreateMap<DataAccess.PhisicalLibrary, Models.PhisicalLibraryViewModel>()
				.ForMember(m => m.Country, opt => opt.MapFrom(s => s.Country.NativeName));
		}
	}
}
