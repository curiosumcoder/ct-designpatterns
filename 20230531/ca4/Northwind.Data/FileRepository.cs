namespace Northwind.Data
{
    public class FileRepository<T> : IMaintenance<T>
    {
        public void Create(T m)
        {
            Console.WriteLine("Writing to file ...");
        }

        public void Delete(T m)
        {
            Console.WriteLine("Deleting from file ...");
        }

        public List<T> List()
        {
            Console.WriteLine("Reading from file ...");
            return new List<T>();
        }

        public void Update(T m)
        {
            Console.WriteLine("Updating to file ...");
        }
    }
}
