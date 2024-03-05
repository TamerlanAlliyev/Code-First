using Microsoft.AspNetCore.Mvc;
using EfCodeFirst.Models.Contexts;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
     

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
