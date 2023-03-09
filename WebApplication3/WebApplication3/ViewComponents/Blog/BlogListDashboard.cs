using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {

        BlogManager writerManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = writerManager.GetBlogListWithCategory();
            return View(values);
        }
    }
}
