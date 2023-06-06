using Northwind.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    /// <summary>
    /// Interface Segregation (ISP)
    /// Create, Update, Delete
    /// </summary>
    public interface IWrite
    {
        void Create(Product m);

        void Delete(Product m);

        void Update(Product m);
    }
}
