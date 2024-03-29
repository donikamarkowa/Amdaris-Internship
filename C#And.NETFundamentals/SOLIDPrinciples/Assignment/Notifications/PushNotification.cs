using System.Text;
using Assignment.Users;

namespace Assignment.Notifications
{
    public class PushNotification : INotification
    {
        public string SendNotification(User sender, User recipient, string message, string subject)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Push notiification From: {sender.Name}")
                .AppendLine($"To: {recipient.Name}")
                .AppendLine($"Message: {message}");

            return sb.ToString();
        }
    }
}
