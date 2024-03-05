using Microsoft.AspNetCore.Mvc;
using EfCodeFirst.Models.Contexts;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext data;
        public HomeController(DataContext data)
        {
            this.data = data;
        }

        //public IActionResult Index()
        //{
        //    var sizes = data.Sizes.ToList();
        //    return Json(sizes);
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
