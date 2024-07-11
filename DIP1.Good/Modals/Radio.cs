using DIP1.Good.Interface;

namespace DIP1.Good.Modals
{
    public class Radio : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Radio: Radio turned on...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Radio: Radio turned off...");
        }
    }
}
