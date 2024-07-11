namespace LSP2.Bad.Models;

public abstract class Employee
{
    public virtual string GetWorkDetails(int id)
    {
        return "Base Work";
    }

    public virtual string GetEmployeeDetails(int id)
    {
        return "Base Employee";
    }

    public abstract decimal CalculateBonus(decimal salary);
}