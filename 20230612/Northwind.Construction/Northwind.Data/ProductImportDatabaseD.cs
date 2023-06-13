using Northwind.Model;

namespace Northwind.Data
{
    public class ProductImportDatabaseD : ProductImportD
    {
        public override void Create(Product p)
        {
            base.Create(p);

            Console.WriteLine("on database ...");
        }
    }
}
