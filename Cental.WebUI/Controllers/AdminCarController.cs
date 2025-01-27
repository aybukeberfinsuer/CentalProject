using Cental.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
	public class AdminCarController(ICarService _carServie) : Controller
	{
		public IActionResult Index()
		{
			var values = _carServie.TGetCarsWithBrands();
			return View(values);
		}
	}
}
