using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.BannerDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
	public class AdminBannerController(IBannerService _bannerService, IMapper _mapper) : Controller
	{
		
		public IActionResult Index()
		{
			var result = _bannerService.TGetAll();
			var banners=_mapper.Map<List<ResultBannerDTO>>(result);
			return View(banners);
		}

		public IActionResult CreateBanner()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateBanner(CreateBannerDTO model)
		{
			var banner = _mapper.Map<Banner>(model);
			_bannerService.TCreate(banner);
			return RedirectToAction("Index");
		}
	}
}
