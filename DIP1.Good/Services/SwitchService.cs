using DIP1.Bad.Modals;
using DIP1.Good.Interface;

namespace DIP1.Bad.Services
{
    public class SwitchService
    {
        private ISwitchable lightBulb;

        private bool SwitchOn;

        public SwitchService(ISwitchable lightBulb)
        {
            this.SwitchOn = false;
            this.lightBulb = lightBulb;
        }

        public void Switch()
        {
            if (SwitchOn)
            {
                lightBulb.TurnOff();
            }
            else
            {
                lightBulb.TurnOn();
            }

            SwitchOn = !SwitchOn;
        }

    }
}
