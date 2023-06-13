using Northwind.Data;

namespace Northwind.FactoryMethod
{
    public abstract class Creator
    {
        public abstract IWrite CreateProductD();
    }
}