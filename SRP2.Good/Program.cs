using Shared.Interfaces;
using Shared.Models;
using SRP2.Bad.Services;

ILogger logger = new FileErrorLogger();
IDataSaver datasaver = new ConsoleDataSaver();
InvoiceService employee = new InvoiceService(1, "Order invoice", logger, datasaver);
employee.Add();

Console.ReadKey();