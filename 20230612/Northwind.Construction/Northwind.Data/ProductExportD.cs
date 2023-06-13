using Northwind.Model;

namespace Northwind.Data
{
    public class ProductExportD : IWrite
    {
        public virtual void Create(Product p)
        {
            Console.WriteLine("Creating a product for exportation ...");
        }
    }
}