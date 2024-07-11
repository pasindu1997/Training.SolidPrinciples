namespace OCP2.Good.Modals
{
    public class GooglePayment : Payment
    {
        public GooglePayment(double Amount) : base("GooglePayment", Amount)
        {
        }

        public override string Pay()
        {
            return "Paying via google pay";
        }
    }
}
