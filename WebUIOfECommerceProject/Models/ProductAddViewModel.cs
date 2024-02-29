using App.Entities.Models;

namespace WebUIOfECommerceProject.Models
{
	public class ProductAddViewModel
	{
		public Product Product { get; set; }
		public List<Category> Categories { get; set; }
	}
}
