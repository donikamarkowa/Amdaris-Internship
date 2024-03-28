using System.Text;
using Assignment.Users;

namespace Assignment.Notifications
{
    public class EmailNotification : INotification
    {
        public string SendNotification(User sender, User recipient, string message, string subject)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Email notiification From: {sender.Email}")
                .AppendLine($"To: {recipient.Email}")
                .AppendLine($"Subject: {subject}")
                .AppendLine($"Message: {message}");

            return sb.ToString();
        }
    }
}
