using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            var model = Reviews.OrderBy(x => x.Country);

            return View(model);
        }


        private static readonly List<RestaurantReview> Reviews = new List<RestaurantReview>
        {
            new RestaurantReview
            {
                Id = 1,
                // !!! xss - in view dont use Html.Raw, use Html.DisplayFor
                Name = "<script>alert('xss');</script>",
                City = "City1",
                Country = "Country1",
                Rating = 1
            },
            new RestaurantReview
            {
                Id = 2,
                Name = "Name2",
                City = "City2",
                Country = "Country2",
                Rating = 2
            },
            new RestaurantReview
            {
                Id = 3,
                Name = "Name3",
                City = "City3",
                Country = "Country3",
                Rating = 3
            },
        };
    }
}