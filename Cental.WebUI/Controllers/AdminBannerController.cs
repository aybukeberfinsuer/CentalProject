using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.AboutDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
	public class AdminBannerController(IBannerService _bannerService, IMapper _mapper) : Controller
	{
		
		public IActionResult Index()
		{
			var result = _bannerService.TGetAll();
			var banners=_mapper.Map<List<ResultAboutDto>>(result);
			return View(banners);
		}
	}
}
