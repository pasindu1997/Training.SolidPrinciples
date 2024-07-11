using ISP1.Good.Interfaces;

namespace ISP1.Good.Modals
{
    public class Car : IDrive
    {
        public string Drive()
        {
            return "Driving the car";
        }
    }
}
