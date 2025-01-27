using Cental.BusinessLayer.Abstract;
using Cental.BusinessLayer.Concrete;
using Cental.DataAccessLayer.Abstract;
using Cental.DataAccessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Extensions
{
	public static class ServiceRegistrations
	{
		public static void AddServiceRegistrations(this IServiceCollection services)
		{
			services.AddScoped<IAboutDal, EFAboutDal>();
			services.AddScoped<IAboutService, AboutManager>();

			services.AddScoped<IBannerDal, EFBannerDal>();
			services.AddScoped<IBannerService, BannerManager>();

			services.AddScoped<IBrandDal, EFBrandDal>();
			services.AddScoped<IBrandService, BrandManager>();

			services.AddScoped<ICarDal, EFCarDal>();
			services.AddScoped<ICarService, CarManager>();


		}

	}
}
