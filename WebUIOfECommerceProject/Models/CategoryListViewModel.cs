using App.Entities.Models;

namespace WebUIOfECommerceProject
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
		public int CurrentCategory { get; set; }
	}
}