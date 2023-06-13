using Northwind.Data;

namespace Northwind.AbstractFactory
{
    public class ProductDatabaseCreator : IAbstractFactory
    {
        public IWrite CreateProductExportD()
        {
            return new ProductExportDatabaseD();
        }

        public IWrite CreateProductImportD()
        {
            return new ProductImportDatabaseD();
        }
    }
}
