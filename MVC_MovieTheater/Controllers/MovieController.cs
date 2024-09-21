using Microsoft.AspNetCore.Mvc;

namespace MVC_MovieTheater.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details() 
        {
            return View();
        }
        public IActionResult Update() 
        {
            return View();
        }
        public IActionResult Delete() 
        {
            return View();
        }
    }
}
