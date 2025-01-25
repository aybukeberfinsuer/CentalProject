using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DataAccessLayer.Abstract;
using Cental.DtoLayer.AboutDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
	public class DefaultAboutComponent:ViewComponent
	{

		private readonly IAboutService aboutService;
		private readonly IMapper mapper;
		public DefaultAboutComponent(IAboutService aboutService, IMapper mapper)
		{
			this.aboutService = aboutService;
			this.mapper = mapper;
		}

		public IViewComponentResult Invoke()
		{
			var values = aboutService.TGetAll();
			var abouts=mapper.Map<List<ResultListDto>>(values);
			return View(abouts);
		}


	}
}
