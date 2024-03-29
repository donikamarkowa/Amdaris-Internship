using Assignment.Enums;
using Assignment.Interfaces;

namespace Assignment.Participants
{
    public class Customer : IObserver
    {
        private string _name;
        public Customer(string name)
        {
            _name = name;
        }
        public void Update(BookOrderStatus orderStatus)
        {
            Console.WriteLine($"Customer {_name}: Order status updated - {orderStatus}");
        }
    }
}
