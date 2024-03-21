namespace NotificationSystem.Channels
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void SendNotification(User sender, User recipient, string subject, string message)
        {
            Console.WriteLine($"Sending SMS notification from {sender.Username} to {recipient.Username} with Subject: {subject}. Message: {message}");
        }
    }
}
