namespace SRP1.Bad.Services;

public class EmployeeService
{
    public int Id { get; set; }

    public string Name { get; set; }

    public EmployeeService(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Add()
    {
        try
        {
            // Logic for adding the employee to the database
            Console.WriteLine($"Employee {Name} with id {Id} added to the database.");
        }
        catch (Exception ex)
        {
            //Saving error to a file.
            File.WriteAllText(@"C:\ErrorLog.txt", ex.ToString());
        }
    }
}
