using Northwind.Data;
using Northwind.Model;

namespace Northwind.FactoryMethod
{
    public class ProductDImportCreator : Creator
    {
        public override IWrite CreateProductD()
        {
            return new ProductImportD();
        }
    }
}
