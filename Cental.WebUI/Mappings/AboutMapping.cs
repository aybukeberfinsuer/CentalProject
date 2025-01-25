using AutoMapper;
using Cental.DtoLayer.AboutDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
	public class AboutMapping:Profile
	{
		public AboutMapping()
		{
			var thisyear = DateTime.Now.Year;
			CreateMap<About, ResultListDto>().ForMember(destination => destination.ExperienceYear,
												o => o.MapFrom(src => thisyear - src.StartYear));
			CreateMap<About, ResultAboutDto>().ReverseMap();
			CreateMap<About, CreateAboutDto>().ReverseMap();
			CreateMap<About, UpdateAboutDto>().ReverseMap();
		}


	}
}
