using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebApplication3.ViewComponents.Category
{
	public class CategoryList: ViewComponent
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

		public IViewComponentResult Invoke()
		{
			var values = categoryManager.GetList();	
			return View(values);
		}
	}
}
