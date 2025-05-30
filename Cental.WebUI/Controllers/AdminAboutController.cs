﻿using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.AboutDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
	[Authorize]
	public class AdminAboutController : Controller
	{
		private readonly IAboutService _aboutService;

		public AdminAboutController(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		public IActionResult Index()
		{

			var values = _aboutService.TGetAll();
			var result = values.Select(x => new ResultAboutDto
			{
				AboutId= x.AboutId,
				Vision= x.Vision,
				Mission= x.Mission,
			}).ToList();
			return View(result);
		}

		public IActionResult CreateAbout()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateAbout(CreateAboutDto model)
		{
			_aboutService.TCreate(new About
			{
				Description1 = model.Description1,
				Description2= model.Description2,
				ImageUrl1=model.ImageUrl1,
				ImageUrl2=model.ImageUrl2,
				Item1=model.Item1,
				Item2=model.Item2,
				Item3=model.Item3,
				Item4=model.Item4,
				JobTitle=model.JobTitle,
				Mission=model.Mission,
				NameSurname=model.NameSurname,
				ProfilePicture=model.ProfilePicture,
				StartYear=model.StartYear,
				Vision=model.Vision

			});
			return RedirectToAction("Index");
		}


		public IActionResult DeleteAbout(int id) {
		
			_aboutService.TDelete(id);
			return RedirectToAction("Index");
		}

		public IActionResult EditAbout(int id) {
		
			var model= _aboutService.TGetById(id);
			var about = new UpdateAboutDto
			{
				AboutId = model.AboutId,
				Description1 = model.Description1,
				Description2 = model.Description2,
				ImageUrl1 = model.ImageUrl1,
				ImageUrl2 = model.ImageUrl2,
				Item1 = model.Item1,
				Item2 = model.Item2,
				Item3 = model.Item3,
				Item4 = model.Item4,
				JobTitle = model.JobTitle,
				Mission = model.Mission,
				NameSurname = model.NameSurname,
				ProfilePicture = model.ProfilePicture,
				StartYear = model.StartYear,
				Vision = model.Vision
			};

			return View(about);
		}

		[HttpPost]
		public IActionResult EditAbout(UpdateAboutDto model)
		{

			var about = new About {
				AboutId= model.AboutId,
				Description1 = model.Description1,
				Description2 = model.Description2,
				ImageUrl1 = model.ImageUrl1,
				ImageUrl2 = model.ImageUrl2,
				Item1 = model.Item1,
				Item2 = model.Item2,
				Item3 = model.Item3,
				Item4 = model.Item4,
				JobTitle = model.JobTitle,
				Mission = model.Mission,
				NameSurname = model.NameSurname,
				ProfilePicture = model.ProfilePicture,
				StartYear = model.StartYear,
				Vision = model.Vision
			};

			_aboutService.TUpdate(about);
			return RedirectToAction("Index");
		}





	}
}
