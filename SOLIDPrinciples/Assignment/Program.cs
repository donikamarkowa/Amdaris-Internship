using Assignment.Enums;
using Assignment.Services;
using Assignment.Users;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Anna Dimitrova", "anna123@gmail.com", "0893657786");
            User user2 = new User("Kiril Kirilov", "kiril22@mail.com", "0899761002");
            User user3 = new User("Petya Petrova", "petyaa@abv.bg", "0897900123");
            User user4 = new User("Nikola Nikolov", "nikola@gmail.com", "0899978111");
            NotificationService notificationService = new NotificationService();

            notificationService.SendNotificationToUser(user1, user2, "Hello, Anna!",  "hello", NotificationChannel.Email);

            notificationService.SendNotificationToUser(user2, user1, "Hello, Kiril!", " ", NotificationChannel.Sms);

            notificationService.SendNotificationToUser(user3, user4, "Hello, Petya!", " ", NotificationChannel.Push);

        }
    }
}
