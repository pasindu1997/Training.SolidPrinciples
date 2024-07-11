using DIP2.Good.Interfaces;

namespace DIP2.Good.Services;

public class EmailService : IMessageService
{
    public void SendMessage(string toContactInfo, string message)
    {
        // Code for sending email
        Console.WriteLine("Email sent");
    }
}