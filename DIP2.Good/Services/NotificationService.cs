using DIP2.Good.Interfaces;

namespace DIP2.Good.Services;

public class NotificationService
{
    private IMessageService _messageService;

    public NotificationService(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void PromotionalNotification(string toContactInfo, string message)
    {
        _messageService.SendMessage(toContactInfo, message);
    }
}