using Microsoft.AspNet.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        [HttpPost]
        public IActionResult Search(string name)
        {
            // TODO: this is xss vulnerable
            return Content("Hello! " + name);
        }

        [HttpGet]
        public IActionResult Search()
        {
            return Content("Search!");
        }
    }
}