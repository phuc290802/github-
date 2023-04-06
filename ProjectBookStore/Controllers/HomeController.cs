using Microsoft.AspNetCore.Mvc;
using ProjectBookStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using X.PagedList;

namespace ProjectBookStore.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		QuanLiBanSachContext db = new QuanLiBanSachContext();
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index(int? page)
		{

			int pagesize = 6;
			int pageNumber = page == null || page < 0 ? 1 : page.Value;
			var lstsanpham = db.Saches.AsNoTracking().OrderBy(x => x.TenSach);
			PagedList<Sach> lst = new PagedList<Sach>(lstsanpham,
				pageNumber, pagesize);
			return View(lst);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}