using NotificationSystem.Notifications;

namespace NotificationSystem.Channels
{
    public class PushNotificationChannel : NotificationChannel
    {
        public override void SendNotification(User sender, User recipient, string message, string subject)
        {
            base.SendNotification(sender, recipient, message, subject);

            var newNotification = new PushNotification(sender, message);

            recipient.PushNotification.Add(newNotification);
            Console.WriteLine(newNotification.Information());
        }
    }
}
