using Northwind.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public interface IMaintenance<T>
    {
        void Create(T m);
        List<T> List();
        void Update(T m);
        void Delete(T m);
    }
}
