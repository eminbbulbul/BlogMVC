using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		CommentManager commentManager = new CommentManager(new EfCommentRepository());

		public IViewComponentResult Invoke(int id) 
		{
			var values = commentManager.GetList(id);
			return View(values);	
		}
	}
}
