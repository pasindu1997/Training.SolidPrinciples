namespace LSP2.Good.Models;

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
}