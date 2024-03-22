using NotificationSystem.Channels;
using NotificationSystem.Notifications;

namespace NotificationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				User test1 = new User("Test1", "test1@gmail.com", "0896542665");
				User test2 = new User("Test2", "test2@gmail.com", "0899760012");

				var emailNotificationChannel = new EmailNotificationChannel();
				var pushNotificationChannel = new PushNotificationChannel();	
				var smsNotificationChannel = new SmsNotificationChannel();

				emailNotificationChannel.SendNotification(test1, test2, "hello", "Hello, Test2");
				pushNotificationChannel.SendNotification(test2, test1, "new message", "Test2 sent you a message");
				smsNotificationChannel.SendNotification(test1, test2, "call", "Call me if you want");

				var emailNotification = new EmailNotification(test1, test2, "hello", "Hello, Test2");
				var pushNotification = new PushNotification(test2, "Test2 sent you a message");
				var smsNotification = new SmsNotification(test1, test2, test1.PhoneNumber, "Call me if you want");

				Console.WriteLine(smsNotification.Information());
                Console.WriteLine(pushNotification.Information());
                Console.WriteLine(emailNotification.Information());


            }
			catch (Exception)
			{
                Console.WriteLine("There was a problem while sending notification!");
            }
        }
    }
}
