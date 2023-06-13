using Northwind.Model;

namespace Northwind.Data
{
    public class ProductImportD : IWrite
    {
        public virtual void Create(Product p)
        {
            Console.WriteLine("Creating a product for importation ...");
        }
    }
}