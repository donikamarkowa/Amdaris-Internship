using System.Text;

namespace NotificationSystem.Notifications
{
    public class EmailNotification : INotification
    {
        private readonly User sender;
        private readonly User reciever;
        private readonly string subject;
        private readonly string body;
        public EmailNotification(User sender, User reciever, string subject, string body)
        {
            this.sender = sender;
            this.reciever = reciever;
            this.subject = subject; 
            this.body = body;   
        }
        public string Information()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Sender: {sender.Username}");
            sb.AppendLine($"Reciever: {reciever.Username}");
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine($"Message: {body}");
            return sb.ToString();
        }
    }
}
