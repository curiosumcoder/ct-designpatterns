using Northwind.Data;
using Northwind.Model;
using System.Buffers;

namespace Northwind.SimpleFactory
{
    /// <summary>
    /// Simple Factory Practice
    /// </summary>
    public class SimpleProductDFactory
    {
        public IWrite CreateProductD (ProductTypes pt ) {

            IWrite pW = null;

            switch (pt)
            {
                case ProductTypes.Export:
                    pW = new ProductExportD();
                    break;
                case ProductTypes.Import:
                    pW = new ProductImportD();
                    break;
            }

            return pW;
        }
    }
}