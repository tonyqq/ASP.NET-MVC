using Microsoft.AspNet.Mvc;
using OdeToFood.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OdeToFood.Controllers
{
    [Route("api/[controller]")]
    public class Greetings : Controller
    {
        private readonly IGreetingService _greetingService;

        public Greetings(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        // GET: api/values
        [HttpGet]
        public GreetingMessage Get()
        {
            var model = _greetingService.GetTodaysGreeting();
            return model;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
