namespace OCP1.Good.Modals
{
    public class SavingAccount : Account
    {
        public SavingAccount(string name, double initialBalance, string address) : base("Savings", name, initialBalance, address)
        {
        }

        public override double CalculateInterest()
        {
            return this.Balance * 0.1;
        }
    }
}
