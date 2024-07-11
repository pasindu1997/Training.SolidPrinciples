using ISP1.Bad.Interfaces;

namespace ISP1.Bad.Modals
{
    public class Helicoptor : IVehicle
    {
        public string Drive()
        {
            throw new NotImplementedException();
        }

        public string Fly()
        {
            return "Flying the helicoptor";
        }

        public string Sail()
        {
            throw new NotImplementedException();
        }
    }
}
