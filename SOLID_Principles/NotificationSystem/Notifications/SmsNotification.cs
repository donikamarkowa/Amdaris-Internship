using System.Text;

namespace NotificationSystem.Notifications
{
    public class SmsNotification : INotification
    {
        private readonly User sender;
        private readonly User recipient;
        private readonly string message;
        public SmsNotification(User sender, User recipient, string phoneNumber, string message)
        {
            this.recipient = recipient;
            this.sender = sender;
            this.message = message; 
        }
        public string Information()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Sender phone: {sender.PhoneNumber}");
            sb.AppendLine($"Reciever phone: {recipient.PhoneNumber}");
            sb.AppendLine($"Message: {message}");
            return sb.ToString();
        }
    }
}
