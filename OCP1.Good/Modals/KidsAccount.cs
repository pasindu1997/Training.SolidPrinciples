using OCP1.Good.Enums;

namespace OCP1.Good.Modals
{
    public class KidsAccount : Account
    {
        // add enum
        public KidsAccount(string name, double initialBalance, string address) : base(AccountTypeConst.Kids, name, initialBalance, address)
        {
        }

        public override double CalculateInterest()
        {
            return this.Balance * 0.3;
        }
    }
}
