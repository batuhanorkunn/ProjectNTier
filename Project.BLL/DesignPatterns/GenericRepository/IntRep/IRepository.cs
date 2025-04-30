using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
	public interface IRepository<T> where T : BaseEntity
	{
		//List Commands
		List<T> GetAll();
		List<T> GetActives();
		List<T> GetModifieds();
		List<T> GetDeleteds();

		//Modify Commands
		void Add(T item);
		void AddRange(List<T> list);
		void Delete(T item);
		void DeleteRange(List<T> list); //pasife çekme
		void Update(T item);
		void UpdateRange(List<T> list);
		void Destroy(T item);
		void DestroyRange(List<T> list);

		//Linq Commands
		// _db.Products(x=>x.ProductName.Contains("be")).ToList();
		List<T> Where(Expression<Func<T, bool>> exp);
		bool Any(Expression<Func<T, bool>> exp);
		T FirsOrDefault(Expression<Func<T, bool>> exp);
		object Select(Expression<Func<T, object>> exp); //_db.Products.Select(x=> new{})
		IQueryable<X> Select<X>(Expression<Func<T,X>> exp); //_dbProducts.Select(x=> new ProductDTO {})

		//Find Command
		T Find(int id);



	}
}
