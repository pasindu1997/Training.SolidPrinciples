using DIP1.Bad.Modals;

namespace DIP1.Bad.Services
{
    public class SwitchService
    {
        private LightBulb lightBulb;

        private bool SwitchOn;

        public SwitchService(LightBulb lightBulb)
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
