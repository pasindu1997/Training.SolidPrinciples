namespace OCP1.Bad.Modal
{
    public class Account
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public double Balance { get; set; }

        public string AccountType { get; }

        public Account(string accountType, string name, double initialBalance, string address)
        {
            this.AccountType = accountType;
            this.Name = name;
            this.Balance = initialBalance;
            this.Address = address;

        }

        public double CalculateInterest()
        {

            switch (AccountType)
            {
                case "Savings":
                    return this.Balance  * 0.1;

                case "KidsSaving":
                    return this.Balance * 0.3;

                default:
                    return this.Balance * 0.2;
            }
        }   
    }
}
