namespace Northwind.Model
{
    /// <summary>
    /// Observable
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void NotifyObservers();
    }
}
