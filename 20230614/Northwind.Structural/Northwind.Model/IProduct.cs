using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Model
{
    public interface IProduct
    {
        double Price { get; set; }

        string GetDetails();
    }
}
