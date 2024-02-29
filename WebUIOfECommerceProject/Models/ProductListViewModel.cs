﻿using App.Entities.Models;

namespace WebUIOfECommerceProject
{
	public class ProductListViewModel
	{
		public List<Product> Products { get; set; }
		public int CurrentCategory { get; set; }
		public int PageCount { get; set; }
		public int PageSize { get; set; }
		public int CurrentPage { get; set; }
	}
}