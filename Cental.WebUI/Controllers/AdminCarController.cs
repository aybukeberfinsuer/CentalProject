using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.BusinessLayer.Extensions;
using Cental.DtoLayer.CarDtos;
using Cental.DtoLayer.Enums;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cental.WebUI.Controllers
{
	public class AdminCarController(ICarService _carServie,IMapper _mapper,IBrandService _brandService) : Controller
	{

		private void GetValuesinDropDown()
		{

			ViewBag.GasTypes = GetEnumValues.EnumValues<GasTypes>();
			ViewBag.GearTypes = GetEnumValues.EnumValues<GearTypes>();
			ViewBag.Transmissions = GetEnumValues.EnumValues<Transmissions>();
			ViewBag.brands = (from x in _brandService.TGetAll()
							  select new SelectListItem
							  {
								  Text=x.BrandName,
								  Value=x.BrandId.ToString()
							  }).ToList();

		}
		public IActionResult Index()
		{
			var values = _carServie.TGetAll();
			return View(values);
		}

		public IActionResult Create()
		{
			GetValuesinDropDown();
			return View();
		}

		[HttpPost]
		public IActionResult Create(CreateCarDTO model)
		{
			var NewCar = _mapper.Map<Car>(model);
			_carServie.TCreate(NewCar);
			return RedirectToAction("Index");
		}
	}
}
