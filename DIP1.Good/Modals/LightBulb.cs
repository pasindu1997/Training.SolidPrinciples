using DIP1.Good.Interface;

namespace DIP1.Bad.Modals
{
    public class LightBulb : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("LightBulb: Bulb turned on...");
        }

        public void TurnOff()
        {
            Console.WriteLine("LightBulb: Bulb turned off...");
        }
    }
}
