using AutoMapper;
using Cental.DtoLayer.AboutDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
	public class AboutMapping:Profile
	{
		public AboutMapping()
		{
			CreateMap<About, ResultListDto>().ReverseMap();
		}


	}
}
