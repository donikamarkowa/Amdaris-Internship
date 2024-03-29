using Assignment.BookOrder;
using Assignment.Enums;
using Assignment.Participants;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookOrderManager orderProcessor = new BookOrderManager();

            //Customers
            Customer customer1 = new Customer("Charlie");
            Customer customer2 = new Customer("Katy");

            //Staff
            StaffMember staff1 = new StaffMember("Andy");
            StaffMember staff2 = new StaffMember("Dan");

            //Subscribe for order status notiifcations
            orderProcessor.Subscribe(customer1);
            orderProcessor.Subscribe(customer2);
            orderProcessor.Subscribe(staff1);
            orderProcessor.Subscribe(staff2);

            orderProcessor.OrderStatus = BookOrderStatus.Received;
            orderProcessor.OrderStatus = BookOrderStatus.Processing;
            orderProcessor.OrderStatus = BookOrderStatus.Ready;
            orderProcessor.OrderStatus = BookOrderStatus.Shipped;


            //Unsubscribe for order status notifications
            orderProcessor.UnSubscribe(staff2);
            orderProcessor.UnSubscribe(customer2);

            orderProcessor.OrderStatus = BookOrderStatus.Delivered;
        }
    }
}
