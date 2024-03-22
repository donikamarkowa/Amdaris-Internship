using System.Text;

namespace NotificationSystem.Notifications
{
    public class PushNotification : INotification
    {
        private readonly User sender;
        private readonly string message;
        public PushNotification(User sender, string message)
        {
            this.sender = sender;
            this.message = message;
        }
        public string Information()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Notification from: {sender.Username}");
            sb.AppendLine($"Message: {message}");
            return sb.ToString();
        }
    }
}
