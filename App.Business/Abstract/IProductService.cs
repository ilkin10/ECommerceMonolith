using App.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Abstract
{
	public interface IProductService
	{
		List<Product> GetAllProducts();
		List<Product> GetAllProductsByCategoryID(int categoryID);
		void Add(Product product);
		void Update(Product product);
		void Delete(int id);
		Product GetProductByID(int productID);

	}
}
