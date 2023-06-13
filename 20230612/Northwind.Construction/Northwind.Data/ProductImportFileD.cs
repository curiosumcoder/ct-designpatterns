using Northwind.Model;

namespace Northwind.Data
{
    public class ProductImportFileD : ProductImportD
    {
        public override void Create(Product p)
        {
            base.Create(p);

            Console.WriteLine("on file ...");
        }
    }
}
