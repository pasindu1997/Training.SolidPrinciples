namespace OCP2.Bad.Modals
{
    public class Payment
    {
        public string PaymentMethod { get; }

        public double Amount { get; set; }

        public Payment(string PaymentMethod, double Amount)
        {
            this.PaymentMethod = PaymentMethod;
            this.Amount = Amount;
        }

        public string Pay()
        {
            if (PaymentMethod == "Card")
            {
                return "Paying via card";
            }
            else if (PaymentMethod == "GooglePay")
            {
                // Process google pay payment
                return "Paying via google pay";
            }

            return "Invalid payment method";
        }
    }
}
