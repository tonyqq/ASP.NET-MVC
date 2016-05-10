using Microsoft.AspNet.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyDefault()
        {
            return Content("Hello from MyDefault() of HomeController!");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewData["Location"] = "Bratislava, SK";

            var aboutModel = new AboutModel
            {
                Name = "Tonyq",
                Location = "Bratislava"
            };

            return View(aboutModel);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
