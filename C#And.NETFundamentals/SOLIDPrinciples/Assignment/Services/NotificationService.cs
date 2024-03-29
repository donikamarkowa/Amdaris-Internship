using Assignment.Enums;
using Assignment.Notifications;
using Assignment.Users;

namespace Assignment.Services
{
    public class NotificationService
    {
        private readonly Dictionary<NotificationChannel, INotification> _notificationChannels;

        public NotificationService()
        {
            _notificationChannels = new Dictionary<NotificationChannel, INotification>
            {
                { NotificationChannel.Email, new EmailNotification() },
                { NotificationChannel.Sms, new SmsNotification() },
                { NotificationChannel.Push, new PushNotification() }
            };
        }
        public void SendNotificationToUser(User sender, User recipient, string message, string subject, NotificationChannel channel)
        {
            if (_notificationChannels.TryGetValue(channel, out INotification notification))
            {
                if (channel == NotificationChannel.Email)
                {
                    string emailNotification = ((EmailNotification)notification).SendNotification(sender, recipient, message, subject);
                    Console.WriteLine(emailNotification);
                }
                else if (channel == NotificationChannel.Push)
                {
                    string pushNotification = ((PushNotification)notification).SendNotification(sender, recipient, message, subject);
                    Console.WriteLine(pushNotification);
                }
                else if (channel == NotificationChannel.Sms)
                {
                    string pushNotification = ((SmsNotification)notification).SendNotification(sender, recipient, message, subject);
                    Console.WriteLine(pushNotification);
                }
                else
                {
                    notification.SendNotification(sender, recipient, message, subject);
                }
            }
            else
            {
                Console.WriteLine("Invalid notification channel.");
            }
        }
    }
}
