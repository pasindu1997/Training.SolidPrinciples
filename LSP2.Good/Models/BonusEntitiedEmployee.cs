namespace LSP2.Good.Models
{
    public abstract class BonusEntitiedEmployee : Employee
    {
        public abstract decimal CalculateBonus(decimal salary);
    }
}
