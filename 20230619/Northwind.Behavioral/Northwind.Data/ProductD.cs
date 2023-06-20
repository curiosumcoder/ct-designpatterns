using Northwind.Model;

namespace Northwind.Data
{
    public class ProductD
    {
        List<Product> products = new List<Product>() {
            new Product() { Id = 1, Name = "Chai", Price = 100 }, 
            new Product() { Id = 2, Name = "Coffee", Price = 200 },
            new Product() { Id = 3, Name = "Banana", Price = 300 },
            new Product() { Id = 4, Name = "Lemon", Price = 400 }, 
            new Product() { Id = 5, Name = "Coconut", Price = 500 },
            new Product() { Id = 6, Name = "Beans", Price = 600 },
            new Product() { Id = 7, Name = "Apple", Price = 700 }, 
            new Product() { Id = 8, Name = "Pear", Price = 800 },
            new Product() { Id = 9, Name = "Carrot", Price = 900 }
        };

        public void Create(Product m)
        {
            products.Add(m);
        }
        public void Delete(Product m)
        {
            products.Remove(m);
        }
        public List<Product> List()
        {
            return products;
        }
        public void Update(Product m)
        {
            products.Remove(m);
            products.Add(m);
        }
    }
}