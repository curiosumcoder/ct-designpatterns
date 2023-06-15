namespace Northwind.Model
{
    public class ProductDiscountDecorator : IProduct
    {
        readonly IProduct p;
        readonly double discount;

        public ProductDiscountDecorator(IProduct p, double discount) 
        { 
            this.p = p;
            this.discount = discount;
        }

        public double Price {
            get => this.p.Price - (this.p.Price * this.discount);
            set => this.p.Price = value;
        }

        public string GetDetails()
        {
            return this.p.GetDetails();
        }
    }
}
