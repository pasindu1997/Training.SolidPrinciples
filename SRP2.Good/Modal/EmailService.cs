using SRP2.Good.Interfaces;

namespace SRP2.Good.Modal
{
    public class EmailService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
