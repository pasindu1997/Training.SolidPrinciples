namespace LSP1.Bad.Modals
{
    public class Penguin: Bird
    {
        public override string Fly()
        {
            throw new NotImplementedException("Penguin cannot fly");
        }

        public override string Walk()
        {
            return "Penguin is walking";
        }
    }
}
