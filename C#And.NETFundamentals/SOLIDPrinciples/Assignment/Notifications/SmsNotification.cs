using System.Text;
using Assignment.Users;

namespace Assignment.Notifications
{
    public class SmsNotification : INotification
    {
        public string SendNotification(User sender, User recipient, string message, string subject)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Sms notiification From: {sender.PhoneNumber}")
                .AppendLine($"To: {recipient.PhoneNumber}")
                .AppendLine($"Message: {message}");

            return sb.ToString();
        }
    }
}
