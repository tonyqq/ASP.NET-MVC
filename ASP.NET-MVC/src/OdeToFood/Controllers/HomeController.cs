using Microsoft.AspNet.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGreetingService _greetingService;

        public HomeController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyDefault()
        {
            var greeting = _greetingService.GetTodaysGreeting();
            return View(greeting);
        }

        // Example of tag helpers
        public IActionResult MyDefault2()
        {
            var greeting = _greetingService.GetTodaysGreeting();
            return View(greeting);
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
