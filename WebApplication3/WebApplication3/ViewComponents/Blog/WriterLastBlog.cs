using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.ViewComponents.Blog
{
	public class WriterLastBlog : ViewComponent
	{
		BlogManager writerManager = new BlogManager(new EfBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values = writerManager.GetBlogListWithByWriter(1);
			return View(values);
		}
	}
}
