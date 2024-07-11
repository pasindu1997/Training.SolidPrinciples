namespace LSP2.Bad.Models;

public class FullTimeEmployee : Employee
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
