using ISP2.Good.Interfaces;

namespace ISP2.Good.Models;

public class Robot : IWorker, IRechargeable
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharging...");
    }
}