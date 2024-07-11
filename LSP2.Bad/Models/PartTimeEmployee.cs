namespace LSP2.Bad.Models;

public class PartTimeEmployee : Employee
{
    public override string GetWorkDetails(int id)
    {
        return "PartTime Employee has less work";
    }

    public override string GetEmployeeDetails(int id)
    {
        return "PartTime Employee";
    }

    public override decimal CalculateBonus(decimal salary)
    {
        throw new NotImplementedException("Part time employees don't get a bonus");
    }
}
