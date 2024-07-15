using Shared.Interfaces;
using SRP2.Good.Interfaces;

namespace SRP2.Bad.Services
{
    internal class InvoiceService
    {
        public int Id { get; set; }

        public string Name { get; set; }

        private ILogger _logger;

        private IDataSaver _dataSaver;

        private readonly INotificationService _notificationService;

        public InvoiceService(int id, string name, ILogger logger, IDataSaver dataSaver, INotificationService notificationService)
        {
            Id = id;
            Name = name;
            _logger = logger;
            _dataSaver = dataSaver;
            _notificationService = notificationService;
        }

        public void Add()
        {
            try
            {
                // Logic for adding the invoice to the database
                _dataSaver.SaveData($"Invoice {Name} with id {Id} added to the database.");
                _notificationService.Send($"Email sent for invoice {Name} with id {Id}.");
            }
            catch (Exception ex)
            {
                //Saving error to a text file
                _logger.Log(ex.ToString());
            }
        }

        public void Delete()
        {
            try
            {
                // Logic for deleting the invoice to the database
                _dataSaver.SaveData($"Invoice {Name} with id {Id} DELETED from the database.");
                _notificationService.Send($"Email sent for invoice {Name} with id {Id}.");
            }
            catch (Exception ex)
            {
                //Saving error to a text file
                _logger.Log(ex.ToString());
            }
        }
    }
}
