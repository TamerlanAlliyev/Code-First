using EfCodeFirst.Models.Contexts;
using EfCodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EfCodeFirst.Controllers
{
    public class SizeController : Controller
    {
        private readonly DataContext data;
        public SizeController(DataContext data)
        {
            this.data = data;
        }
        public IActionResult Index()    // database-de olan her seyi cedvelde gostermek
        {
            List<Size> sizes = data.Sizes.ToList();
            return View(sizes);
        }

        public IActionResult Details(int id)   
        {
            var size= data.Sizes.Where(m=>m.Id==id);

            if(size is null)
            {
                return NotFound();
            }
            return View(size);
        }


        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(Size model)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
        public IActionResult Edit(Size model)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
