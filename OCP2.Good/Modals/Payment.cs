namespace OCP2.Good.Modals
{
    public abstract class Payment
    {
        public string PaymentMethod { get; }

        public double Amount { get; set; }

        public Payment(string PaymentMethod, double Amount)
        {
            this.PaymentMethod = PaymentMethod;
            this.Amount = Amount;
        }

        public abstract string Pay();
        
    }
}
