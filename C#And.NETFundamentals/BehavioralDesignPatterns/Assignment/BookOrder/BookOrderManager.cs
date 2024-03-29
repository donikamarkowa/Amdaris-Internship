using Assignment.Enums;
using Assignment.Interfaces;

namespace Assignment.BookOrder
{
    public class BookOrderManager : IBookOrderManager
    {
        private List<IObserver> _observers = new List<IObserver>();
        private BookOrderStatus orderStatus;
        public BookOrderStatus OrderStatus
        {
            get { return orderStatus; }
            set
            {
                orderStatus = value;
                Notify();
            }
        }
        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnSubscribe(IObserver observer)
        {
            _observers?.Remove(observer);
        }

        public void Notify()
        {
            foreach (var o in _observers)
            {
                o.Update(orderStatus);
            }
        }
    }
}
