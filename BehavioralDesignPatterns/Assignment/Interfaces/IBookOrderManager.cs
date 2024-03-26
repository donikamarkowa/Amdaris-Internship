namespace Assignment.Interfaces
{
    public interface IBookOrderManager
    {
        void Subscribe(IObserver observer);
        void UnSubscribe(IObserver observer);
        void Notify();
    }
}
