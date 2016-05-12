using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
