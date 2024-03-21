namespace NotificationSystem.Channels
{
    public interface INotificationChannel
    {
        public void SendNotification(User sender, User recipient, string message, string subject);
    }
}
