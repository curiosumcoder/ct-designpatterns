using Northwind.Data;

namespace Northwind.AbstractFactory
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IAbstractFactory
    {
        IWrite CreateProductExportD();

        IWrite CreateProductImportD();
    }
}