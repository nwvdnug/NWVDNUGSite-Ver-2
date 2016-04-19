using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWVDNUG.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var model = BuildHomePageModel();
			return View(model);
		}

		private ActionResult BuildHomePageModel()
		{
		    return View();
		}

		public ActionResult About()
		{
			return View();
		}

		public ViewResult Network()
		{
			return View();
		}

		public ViewResult Sponsors()
		{
			return View();
		}

		public ViewResult Privacy()
		{
			return View();
		}

		//public ActionResult Full()
		//{
			//return File("Views/Home/Full.rss", "text/xml");
			//return View("Full.rss");
		//}
	}
}
