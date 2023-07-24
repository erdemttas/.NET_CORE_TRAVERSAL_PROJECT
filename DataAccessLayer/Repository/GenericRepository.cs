using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
	public class GenericRepository<T> : IGenericDal<T> where T : class  //Gelen T değerleri bir sınıf olmalıdır koşulu.
	{
		public void Delete(T t)
		{
			Context c = new Context();
			c.Remove(t);
			c.SaveChanges();
		}

		public List<T> GetList()
		{
			Context c= new Context();
			return c.Set<T>().ToList();
		}

		public void Insert(T t)
		{
			Context c= new Context();
			c.Add(t);
		}

		public void Update(T t)
		{
			Context c = new Context();
			c.Update(t);
		}

	}
}
