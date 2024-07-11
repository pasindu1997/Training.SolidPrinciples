namespace OCP2.Good.Modals
{
    public class CardPayment : Payment
    {
        public CardPayment(double Amount) : base("Card", Amount)
        {
        }

        public override string Pay()
        {
           return "Paying via credit card";
        }
    }
}
