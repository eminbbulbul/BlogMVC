using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		ContactManager _contactManager = new ContactManager(new EfContactRepository());	
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact p)
		{
			p.ContactDate= DateTime.Parse(DateTime.Now.ToShortDateString());
			p.ContactStatus = true;
			_contactManager.ContactAdd(p);
			return RedirectToAction("Index","Blog");
		}
	}
}
