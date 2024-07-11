namespace LSP2.Good.Models;

public class FullTimeEmployee : BonusEntitiedEmployee
{
    public override string GetWorkDetails(int id)
    {
        return "FullTime Employee has less work";
    }

    public override string GetEmployeeDetails(int id)
    {
        return "FullTime Employee";
    }

    public override decimal CalculateBonus(decimal salary)
    {
        return salary * (10 / 100);
    }
}
