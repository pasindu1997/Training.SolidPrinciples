using Shared.Interfaces;

namespace Shared.Models;

public class ConsoleErrorLogger : ILogger
{
    public void Log(string errorMessage)
    {
        Console.WriteLine("C:/Error", errorMessage);
    }
}