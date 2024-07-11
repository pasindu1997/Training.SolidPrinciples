using DIP2.Bad.Models;

namespace DIP2.Bad.Services;

public class NotificationService
{
    private EmailService _email;

    public NotificationService(EmailService emailService)
    {
        _email = emailService;
    }

    public void PromotionalNotification()
    {
        _email.SendEmail();
    }
}