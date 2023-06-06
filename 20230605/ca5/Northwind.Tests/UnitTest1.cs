using Northwind.Data;
using Northwind.Data.Extensions;
using Northwind.Model;
using System.Runtime.Intrinsics.Arm;

namespace Northwind.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ProductD_List()
        {
            // AAA

            // Arrange
            var pD = new ProductD();

            // Act
            pD.Create(new Product() { Id = 1, Name = "Chai", Price = 100 });
            pD.Create(new Product() { Id = 2, Name = "Coffee", Price = 200 });
            pD.Create(new Product() { Id = 3, Name = "Banana", Price = 300 });

            var data = pD.List();

            // Assert
            Assert.NotEmpty(data);
        }

        [Fact]
        public void ProductD_ListToCSV()
        {
            // AAA

            // Arrange
            var pD = new ProductD();

            // Act
            pD.Create(new Product() { Id = 1, Name = "Chai", Price = 100 });
            pD.Create(new Product() { Id = 2, Name = "Coffee", Price = 200 });
            pD.Create(new Product() { Id = 3, Name = "Banana", Price = 300 });

            // OCP
            var data = pD.ListAsCSV();

            // Assert
            Assert.True(data.Contains(','), "Formato separado por comas. Incorrecto.");
        }

        /// <summary>
        /// Liskov Sustitution (LSP)
        /// </summary>
        [Fact]
        public void Liskov()
        {
            // AAA

            // Arrange
            var pD = new ProductD();

            pD.Create(new ProductImported() { Id = 1, Name = "Chai", Price = 100, Origin = "India" });
            pD.Create(new Product() { Id = 2, Name = "Coffee", Price = 200 });
            pD.Create(new ProductImported() { Id = 3, Name = "Banana", Price = 300, Origin = "Costa Rica" });

            // Act
            var data = pD.List();
            foreach (var p in data)
            {
                p.Details();
            }

            // Assert
        }

        /// <summary>
        /// Interface Segregation (ISP)
        /// </summary>
        [Fact]
        public void InterfaceSegregation()
        {
            // AAA

            // Arrange
            var pD = new ProductD();

            pD.Create(new ProductImported() { Id = 1, Name = "Chai", Price = 100, Origin = "India" });
            pD.Create(new Product() { Id = 2, Name = "Coffee", Price = 200 });
            pD.Create(new ProductImported() { Id = 3, Name = "Banana", Price = 300, Origin = "Costa Rica" });

            // Act
            IRead pR = pD;           

            var data = pR.List();

            // Assert
            Assert.NotEmpty(data);
        }

        /// <summary>
        /// Dependency Inversion (DIP)
        /// </summary>
        [Fact]
        public void DependencyInversion()
        {
            // AAA

            // Arrange
            var pD = new ProductDText();

            // Act
            IWrite pW = pD;

            pW.Create(new ProductImported() { Id = 1, Name = "Chai", Price = 100, Origin = "India" });
            pW.Create(new Product() { Id = 2, Name = "Coffee", Price = 200 });
            pW.Create(new ProductImported() { Id = 3, Name = "Banana", Price = 300, Origin = "Costa Rica" });

            IRead pR = pD; 

            var data = pR.List();

            // Assert
            Assert.NotEmpty(data);
        }
    }
}