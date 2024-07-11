using ISP2.Good.Interfaces;

namespace ISP2.Good.Models;

public class OfficeWorker : IWorker, IEater, IRechargeable
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