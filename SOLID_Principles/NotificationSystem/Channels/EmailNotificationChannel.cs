using NotificationSystem.Notifications;

namespace NotificationSystem.Channels
{
    public class EmailNotificationChannel : NotificationChannel
    {
        public override void SendNotification(User sender, User recipient, string message, string subject)
        {
            base.SendNotification(sender, recipient, message, subject);

            var newNotification = new EmailNotification(sender, recipient, subject, message);
            recipient.EmailNotifications.Add(newNotification);

            Console.WriteLine(newNotification.Information());
        }
    }
        
}
