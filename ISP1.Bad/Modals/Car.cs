using ISP1.Bad.Interfaces;

namespace ISP1.Bad.Modals
{
    public class Car : IVehicle
    {
        public string Drive()
        {
            return "Driving the car";
        }

        public string Fly()
        {
            throw new NotImplementedException();
        }

        public string Sail()
        {
            throw new NotImplementedException();
        }
    }
}
