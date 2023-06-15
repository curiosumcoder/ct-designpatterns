namespace Nothwind.Data
{
    public interface IMaintenance<T>
    {
        void Create(T m);
        void Delete(T m);
        List<T> List();
        void Update(T m);
    }
}
