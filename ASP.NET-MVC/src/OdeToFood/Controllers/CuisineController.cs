using Microsoft.AspNet.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: /Cuisine/
        public IActionResult Search(string name)
        {
            // TODO: this is xss vulnerable
            return Content("Hello! " + name);
        }
    }
}