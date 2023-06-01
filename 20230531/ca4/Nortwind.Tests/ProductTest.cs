using Northwind.UI;
using System.Net.Http.Headers;

namespace Nortwind.Tests
{
    public class ProductTest
    {
        [Fact]
        public void Product_Create()
        {
            // Arrange
            var pUI = new ProductUI();
            // Act
            pUI.Create();
            // Assert
        }

        [Fact]
        public void Product_List()
        {
            // Arrange
            var pUI = new ProductUI();
            // Act
            pUI.List();
            // Assert
        }
    }
}