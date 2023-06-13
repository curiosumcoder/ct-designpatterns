using Northwind.Data;

namespace Northwind.FactoryMethod
{
    public class ProductDExportCreator : Creator
    {
        public override IWrite CreateProductD()
        {
            return new ProductExportD();
        }
    }
}
