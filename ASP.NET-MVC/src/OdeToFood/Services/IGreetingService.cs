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
        private int _id = 1;

        public GreetingMessage GetTodaysGreeting()
        {
            return new GreetingMessage(_id++, "Hello from the greeting service");
        }
    }
}