using DIP1.Bad.Modals;
using DIP1.Good.Interface;

namespace DIP1.Bad.Services
{
    public class SwitchService
    {
        private ISwitchable switchable;

        private bool SwitchOn;

        public SwitchService(ISwitchable switchable)
        {
            this.SwitchOn = false;
            this.switchable = switchable;
        }

        public void Switch()
        {
            if (SwitchOn)
            {
                switchable.TurnOff();
            }
            else
            {
                switchable.TurnOn();
            }

            SwitchOn = !SwitchOn;
        }

    }
}
