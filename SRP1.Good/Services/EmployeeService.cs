using Shared.Interfaces;

public class EmployeeService
{
    public int Id { get; set; }
    public string Name { get; set; }

    private ILogger _logger;
    private IDataSaver _dataSaver;

    public EmployeeService(int id, string name, ILogger logger, IDataSaver dataSaver)
    {
        Id = id;
        Name = name;
        _logger = logger;
        _dataSaver = dataSaver;
    }

    public void Add()
    {
        try
        {
            // Logic for adding the employee to the database
            _dataSaver.SaveData($"Employee {Name} with id {Id} added to the database.");
            //throw new NotImplementedException();
        }
        catch (Exception ex)
        {
            _logger.Log(ex.ToString());
        }
    }
}