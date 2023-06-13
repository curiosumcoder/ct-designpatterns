using Northwind.Model;

namespace Northwind.Data
{
    public interface IWrite
    {
        void Create(Product p);
    }
}
