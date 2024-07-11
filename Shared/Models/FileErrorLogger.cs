using Shared.Interfaces;
using System.Xml.Linq;

namespace Shared.Models;

public class FileErrorLogger : ILogger
{
    public void Log(string errorMessage)
    {
        //File.WriteAllText("C:/Error", errorMessage);
        File.WriteAllText(@"C:/Error/err.txt", errorMessage);
    }
}
