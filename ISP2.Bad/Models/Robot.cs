using ISP2.Bad.Interfaces;

namespace ISP2.Bad.Models;

public class Robot : IEmployee
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        // Robots don't eat, but we're forced to implement this method.
        throw new NotImplementedException();
    }

    public void Recharge()
    {
        Console.WriteLine("Recharging...");
    }
}