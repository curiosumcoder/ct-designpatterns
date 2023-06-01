namespace Northwind.Data
{
    public class MemoryRepository<T> : IMaintenance<T>
    {
        List<T> data = new List<T>();

        public void Create(T m)
        {
            Console.WriteLine("Writing to memory ...");
            data.Add(m);
        }

        public void Delete(T m)
        {
            Console.WriteLine("Deleting from memory ...");
            data.Remove(m);
        }

        public List<T> List()
        {
            Console.WriteLine("Reading from memory ...");
            return data.ToList();
        }

        public void Update(T m)
        {
            Console.WriteLine("Updating to memory ...");
            data.Remove(m);
            data.Add(m);
        }
    }
}
