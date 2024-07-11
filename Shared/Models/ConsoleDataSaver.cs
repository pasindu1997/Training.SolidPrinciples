using Shared.Interfaces;

public class ConsoleDataSaver : IDataSaver
{
    public void SaveData(string message)
    {
        Console.WriteLine(message);
    }
}