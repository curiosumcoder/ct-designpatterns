using Northwind.Data;

namespace Northwind.AbstractFactory
{
    public class ProductFileCreator : IAbstractFactory
    {
        public IWrite CreateProductExportD()
        {
            return new ProductExportFileD();
        }

        public IWrite CreateProductImportD()
        {
            return new ProductImportFileD();
        }
    }
}
