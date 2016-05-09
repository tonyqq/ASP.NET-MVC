using Microsoft.AspNet.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: /Cuisine/
        public IActionResult Search()
        {
            return Content("Hello!");
        }
    }
}