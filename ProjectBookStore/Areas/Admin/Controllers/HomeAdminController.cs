using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectBookStore.Models;
using X.PagedList;

namespace ProjectBookStore.Areas.Admin.Controllers
{

    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        QuanLiBanSachContext db = new QuanLiBanSachContext();
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {

            return View();
        }
        [Route("danhmucsanpham")]
        public IActionResult  DanhMucSanPham(int? page)
        {
            int pagesize = 10;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstsanpham = db.Saches.AsNoTracking().OrderBy(x => x.TenSach);
            PagedList<Sach> lst = new PagedList<Sach>(lstsanpham,
             pageNumber, pagesize);
            return View(lst);
        }
    }
}
