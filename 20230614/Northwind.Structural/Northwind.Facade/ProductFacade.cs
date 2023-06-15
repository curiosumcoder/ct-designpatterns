using Northwind.Model;
using Northwind.Notification;
using Northwind.Storage;
using Northwind.Validation;

namespace Northwind.Facade
{

    public class ProductFacade
    {
        ProductValidation v = new();
        ProductStorage s = new();
        ProductNotification n = new();

        //public ProductFacade(ProductValidation v, ProductStorage s, ProductNotification n) { 

        //    this.v = v;
        //    this.s = s;
        //    this.n = n;
        //}

        public void Create(Product p)
        {
            if (v.Validate(p))
            {
                s.Save(p);
                n.SendNotification(p);
            }
        }
    }
}
