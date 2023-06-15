using Northwind.Model;

namespace Nothwind.Data
{
    public class ProductD : IMaintenance<Product>
    {
        List<Product> products = new List<Product>();

        public ProductD() {
            products.Add(new Product() { Id = 1, Name = "Chai", Price = 100 });
            products.Add(new Product() { Id = 2, Name = "Coffee", Price = 200 });
            products.Add(new Product() { Id = 3, Name = "Banana", Price = 300 });
        }

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