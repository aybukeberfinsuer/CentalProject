using Cental.DataAccessLayer.Abstract;
using Cental.DataAccessLayer.Context;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : BaseEntity
	{
		protected readonly CentalContext _centalContext;

		public GenericRepository(CentalContext centalContext)
		{
			_centalContext = centalContext;
		}

		public void Create(T entity)
		{
			_centalContext.Add(entity);
			_centalContext.SaveChanges();
		}

		public void Delete(int id)
		{
			var value= GetById(id);
			_centalContext.Remove(value);
			_centalContext.SaveChanges();
			
		}

		public List<T> GetAll()
		{
			return _centalContext.Set<T>().ToList();
		}

		public T GetById(int id)
		{
			return _centalContext.Set<T>().Find(id);
		}

		public void Update(T entity)
		{
			_centalContext.Update(entity);
			_centalContext.SaveChanges();
		}
	}
}
