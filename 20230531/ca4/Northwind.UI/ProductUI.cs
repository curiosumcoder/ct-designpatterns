using Northwind.Data;
using Northwind.Model;

namespace Northwind.UI
{
    public class ProductUI
    {
        IMaintenance<Product> repo = new MemoryRepository<Product>();

        public void Create()
        {
            var id = new Random().Next(1, 100);
            var p = new Product() { Id = id, Name = $"Product {id.ToString()}", Price = 100 * id };

            repo.Create(p);
        }

        public void List()
        {
            Console.WriteLine("Listado de productos");

            var products = repo.List();

            foreach (var p in products)
            {
                Console.WriteLine($"\nDetalle de producto");
                Console.WriteLine($"\t{p.Id} {p.Name} {p.Price}");
            }
        }
    }
}