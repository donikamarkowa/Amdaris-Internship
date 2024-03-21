namespace NotificationSystem.Channels
{
    public class EmailNotificationChannel : INotificationChannel
    {
        public void SendNotification(User sender, User recipient, string message, string subject)
        {
            Console.WriteLine($"Sending email notification from {sender.Email} to {recipient.Email} with Subject: {subject}. Message: {message}");
        }
    }
}
