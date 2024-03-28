using Assignment.Users;

namespace Assignment.Notifications
{
    public interface INotification
    {
        string SendNotification(User sender, User recipient, string message, string subject);
    }
}
