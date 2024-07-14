using OCP1.Good.Enums;

namespace OCP1.Good.Modals
{
    public class SavingAccount : Account
    {
        public SavingAccount(string name, double initialBalance, string address) : base(AccountTypeConst.Savings, name, initialBalance, address)
        {
        }

        public override double CalculateInterest()
        {
            return this.Balance * 0.1;
        }
    }
}
