using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
{
    public class GreetingMessage
    {
        public GreetingMessage(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public int Id { get; set; }

        public string Text { get; set; }
    }

    public interface IGreetingService
    {
        GreetingMessage GetTodaysGreeting();
    }

    public class GreetingService : IGreetingService
    {
        private readonly IConfiguration _config;

        public GreetingService(IConfiguration config)
        {
            _config = config;
        }

        private int _id = 1;

        public GreetingMessage GetTodaysGreeting()
        {
            var text = _config.Get<string>("message");
            return new GreetingMessage(_id++, text);
        }
    }
}