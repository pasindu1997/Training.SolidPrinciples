using ISP1.Bad.Interfaces;

namespace ISP1.Bad.Modals
{
    public class Boat : IVehicle
    {
        public string Drive()
        {
            throw new NotImplementedException();
        }

        public string Fly()
        {
            throw new NotImplementedException();
        }

        public string Sail()
        {
            return "Sailing the boat";
        }
    }
}
