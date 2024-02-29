﻿using App.Business.Abstract;
using App.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using WebUIOfECommerceProject.Models;

namespace WebUIOfECommerceProject.Controllers
{
	public class ProductController : Controller
	{

		private IProductService _productService;
		private ICategoryService _categoryService;

		public ProductController(IProductService productService, ICategoryService categoryService = null)
		{
			_productService = productService;
			_categoryService = categoryService;
		}

		public IActionResult Index(int page = 1,int category = 0)
		{
			int pageSize = 6;
			var products = _productService.GetAllProductsByCategoryID(category);
			var model = new ProductListViewModel
			{
				Products = products.Skip((page-1)*pageSize).Take(pageSize).ToList(),
				CurrentCategory = category,
				PageCount = (int)Math.Ceiling(products.Count/(double)pageSize),
				PageSize = pageSize,
				CurrentPage = page
			};
			return View(model);
		}

		[HttpGet]
		public IActionResult Add()
		{
			var model = new ProductAddViewModel();
			model.Product = new Product();
			model.Categories = _categoryService.GetAll();
			return View(model);
		}

		[HttpPost]
		public IActionResult Add(ProductAddViewModel model)
		{
			_productService.Add(model.Product);
			return RedirectToAction("index");
		}

	}
}
