using DIP2.Good.Interfaces;
using DIP2.Good.Services;

IMessageService smsService = new SMSService();  // we can easily substitute this with new SMS()
IMessageService emailService = new EmailService();  // we can easily substitute this with new EmailService()
NotificationService notification = new NotificationService(smsService);
notification.PromotionalNotification("+9471045876", "Hi");