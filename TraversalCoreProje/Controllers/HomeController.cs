using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
