using Shared.Interfaces;

namespace SRP2.Bad.Services
{
    internal class InvoiceService
    {
        public int Id { get; set; }

        public string Name { get; set; }

        private ILogger _logger;

        private IDataSaver _dataSaver;

        public InvoiceService(int id, string name, ILogger logger, IDataSaver dataSaver)
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
                // Logic for adding the invoice to the database
                _dataSaver.SaveData($"Invoice {Name} with id {Id} added to the database.");
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
            }
            catch (Exception ex)
            {
                //Saving error to a text file
                _logger.Log(ex.ToString());
            }
        }

        public void SendEmail()
        {
            try
            {
                // Logic for sending an email with the invoice details
                Console.WriteLine($"Email sent for invoice {Name} with id {Id}.");
            }
            catch (Exception ex)
            {
                //Sending failed error to a text file
                _logger.Log(ex.ToString());
            }
        }
    }
}
