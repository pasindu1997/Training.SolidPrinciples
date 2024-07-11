using DIP2.Good.Interfaces;

namespace DIP2.Good.Services;

public class SMSService : IMessageService
{
    public void SendMessage(string toContactInfo, string message)
    {
        // Code for sending SMS
        Console.WriteLine("SMS sent");
    }
}