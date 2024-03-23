using NotificationSystem.Notifications;

namespace NotificationSystem.Channels
{
    public class SmsNotificationChannel : NotificationChannel
    {
        public override void SendNotification(User sender, User recipient, string message, string subject)
        {
            base.SendNotification(sender, recipient, message, subject);

            var newNotification = new SmsNotification(sender, recipient, sender.PhoneNumber, message);

            recipient.SmsNotification.Add(newNotification);
            Console.WriteLine(newNotification.Information());
        }
    }
}
