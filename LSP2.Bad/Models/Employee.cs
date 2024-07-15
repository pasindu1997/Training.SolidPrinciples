namespace LSP2.Bad.Models;

public abstract class Employee
{
    public abstract string GetWorkDetails(int id);

    public abstract string GetEmployeeDetails(int id);

    public abstract decimal CalculateBonus(decimal salary);
}