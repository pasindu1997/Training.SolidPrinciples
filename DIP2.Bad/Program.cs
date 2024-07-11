using DIP2.Bad.Models;
using DIP2.Bad.Services;

EmailService email = new EmailService();
NotificationService notification = new NotificationService(email);
notification.PromotionalNotification();