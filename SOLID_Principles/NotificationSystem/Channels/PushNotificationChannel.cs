namespace NotificationSystem.Channels
{
    public class PushNotificationChannel : INotificationChannel
    {
        public void SendNotification(User sender, User recipient, string subject, string message)
        {
            Console.WriteLine($"Sending push notification from {sender.Username} to {recipient.Username}. Message: {message}");
        }
    }
}
