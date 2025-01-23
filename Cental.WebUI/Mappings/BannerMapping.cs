using AutoMapper;
using Cental.DtoLayer.BannerDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
	public class BannerMapping: Profile
	{
		public BannerMapping()
		{
			CreateMap<Banner, ResultBannerDTO>().ReverseMap();
			CreateMap<Banner, CreateBannerDTO>().ReverseMap();
			CreateMap<Banner, UpdateBannerDTO>().ReverseMap();
		}
	}
}
