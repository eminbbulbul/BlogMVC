using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.ViewComponents.Blog
{
	public class BlogLast3Post: ViewComponent
	{
		BlogManager writerManager = new BlogManager(new EfBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values = writerManager.GetLast3Blog();
			return View(values);
		}
	}
}
