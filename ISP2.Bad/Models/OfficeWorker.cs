using ISP2.Bad.Interfaces;

namespace ISP2.Bad.Models;

public class OfficeWorker : IEmployee
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharging...");
    }
}
