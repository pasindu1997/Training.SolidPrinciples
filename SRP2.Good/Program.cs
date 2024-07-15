using Shared.Interfaces;
using Shared.Models;
using SRP2.Bad.Services;
using SRP2.Good.Interfaces;
using SRP2.Good.Modal;

ILogger logger = new FileErrorLogger();
IDataSaver datasaver = new ConsoleDataSaver();
INotificationService notificationService = new EmailService();
InvoiceService employee = new InvoiceService(1, "Order invoice", logger, datasaver, notificationService);
employee.Add();

Console.ReadKey();