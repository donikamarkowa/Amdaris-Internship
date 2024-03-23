using System.Threading.Tasks.Dataflow;

namespace NotificationSystem.Channels
{
    public abstract class NotificationChannel : INotificationChannel
    {
        public virtual void SendNotification(User sender, User recipient, string message, string subject)
        {
            if (sender is null || recipient is null || message is null || subject is null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
