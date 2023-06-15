using Northwind.Facade;
using Northwind.Model;
using Northwind.Notification;
using Northwind.Storage;
using Northwind.Validation;

namespace Northwind.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DecoratorStructural_Test()
        {
            // Arrange
            IProduct p1 = new Product() { Id = 1, Name = "Banana", Price = 100 };

            // Act
            IProduct p2 = new ProductDiscountDecorator(p1, 0.2);

            // Assert
            Assert.Equal(100, p1.Price);
            Assert.Equal(80, p2.Price);
        }

        [Fact]
        public void AdapterStructural_Test()
        {
            // Arrange
            IProduct p1 = new Product() { Id = 1, Name = "Banana", Price = 100 };

            // Act
            IProductNew p2 = new ProductAdapter(p1);

            // Assert
            Assert.Equal("1, Banana, 100", p1.GetDetails());
            Assert.Equal("1, Banana, 100", p2.Details());
        }

        [Fact]
        public void FacadeStructural_Test()
        {
            // Arrange
            var p1 = new Product() { Id = 1, Name = "Banana", Price = 100 };

            // Act

            // Create a product
            //var pV = new ProductValidation();

            //if (pV.Validate(p1))
            //{
            //    var pS = new ProductStorage();
            //    pS.Save(p1);

            //    var n = new ProductNotification();
            //    n.SendNotification(p1);
            //}

            var pF = new ProductFacade();
            pF.Create(p1);

            // Assert
            //Assert.Equal("1, Banana, 100", p1.GetDetails());
            //Assert.Equal("1, Banana, 100", p2.Details());
        }
    }
}