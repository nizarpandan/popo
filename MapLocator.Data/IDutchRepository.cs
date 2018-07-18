using System.Collections.Generic;
using MapLocator.Data.Entities;

namespace MapLocator.Data
{
	public interface IDutchRepository
	{
		IEnumerable<Product> GetAllProducts();
		IEnumerable<Order> GetAllOrders();
		IEnumerable<Product> GetProductsByCategory(string category);
		bool SaveAll();
	}
}