using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
	public class DefaultController : Controller
	{
		[Area("Admin")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
