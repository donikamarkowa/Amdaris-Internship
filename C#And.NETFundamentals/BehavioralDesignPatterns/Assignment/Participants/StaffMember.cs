using Assignment.Enums;
using Assignment.Interfaces;

namespace Assignment.Participants
{
    public class StaffMember : IObserver
    {
        private string _name;
        public StaffMember(string name)
        {
            _name = name;
        }
        public void Update(BookOrderStatus orderStatus)
        {
            Console.WriteLine($"Staff Member {_name}: New order status - {orderStatus}");
        }
    }
}
