using Assignment.Enums;

namespace Assignment.Interfaces
{
    public interface IObserver
    {
        void Update(BookOrderStatus orderStatus);
    }
}
