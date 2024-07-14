namespace OCP1.Good.Modals
{
    public abstract class Account
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public double Balance { get; set; }

        public string AccountType { get; }

        public Account(string accountType, string name, double initialBalance, string address)
        {
            AccountType = accountType;
            Name = name;
            Balance = initialBalance;
            Address = address;
        }

        public abstract double CalculateInterest();
    }
}
