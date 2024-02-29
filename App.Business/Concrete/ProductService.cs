using App.Business.Abstract;
using App.DataAccess.Abstract;
using App.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Concrete
{
	public class ProductService : IProductService
	{
		private IProductDal _productDal;

		public ProductService(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void Add(Product product)
		{
			_productDal.Add(product);
		}

		public void Delete(int id)
		{
			var item = _productDal.Get(p => p.ProductId == id);
			_productDal.Delete(item);
		}

		public List<Product> GetAllProducts()
		{
			return _productDal.GetList();
		}

		public List<Product> GetAllProductsByCategoryID(int categoryID)
		{
			return _productDal.GetList(p => p.CategoryId == categoryID || categoryID == 0).ToList();	
		}

		public Product GetProductByID(int productID)
		{
			return _productDal.Get(p => p.ProductId == productID);
		}

		public void Update(Product product)
		{
			_productDal.Update(product);
		}
	}
}
