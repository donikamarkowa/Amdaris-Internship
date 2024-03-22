using NotificationSystem.Notifications;

namespace NotificationSystem
{
    public class User
    {
        private readonly List<EmailNotification> emailNotifications;
        private readonly List<PushNotification> pushNotifications;
        private readonly List<SmsNotification> smsNotifications;

        public User(string username, string email, string phoneNumber)
        {
            this.Username = username;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.emailNotifications = new List<EmailNotification>();    
            this.pushNotifications = new List<PushNotification>();  
            this.smsNotifications = new List<SmsNotification>();    
        }

        public string Username { get; set; }
        public string Email { get; set; } 
        public string PhoneNumber { get; set; }

        public void RecieveNotification(INotification notification)
        {
            if (notification is EmailNotification)
            {
                emailNotifications.Add((EmailNotification)notification);
            }
            else if (notification is SmsNotification)
            {
                smsNotifications.Add((SmsNotification)notification);
            }
            else if (notification is PushNotification)
            {
                pushNotifications.Add((PushNotification)notification);
            }
            else
            {
                throw new ArgumentException("Unsupported notification type.");
            }
        }
    }
}
