using Northwind.Model;

namespace Northwind.Data
{
    public class ProductExportDatabaseD : ProductExportD
    {
        public override void Create(Product p)
        {
            base.Create(p);

            Console.WriteLine("on database ...");
        }
    }
}
