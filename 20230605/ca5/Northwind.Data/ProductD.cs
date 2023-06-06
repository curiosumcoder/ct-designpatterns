using Northwind.Model;

namespace Northwind.Data
{
    /// <summary>
    /// SRP
    /// </summary>
    public class ProductD : IWrite, IRead
    {
        List<Product> products = new List<Product>();

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
