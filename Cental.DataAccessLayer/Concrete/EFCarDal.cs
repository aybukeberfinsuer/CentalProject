using Cental.DataAccessLayer.Abstract;
using Cental.DataAccessLayer.Context;
using Cental.DataAccessLayer.Repositories;
using Cental.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccessLayer.Concrete
{
	public class EFCarDal : GenericRepository<Car>, ICarDal
	{
		public EFCarDal(CentalContext centalContext) : base(centalContext)
		{
		}

		public List<Car> GetCarsWithBrands()
		{
			//eager loading
			return _centalContext.Cars.Include(x=>x.Brand).ToList();
		}
	}
}
