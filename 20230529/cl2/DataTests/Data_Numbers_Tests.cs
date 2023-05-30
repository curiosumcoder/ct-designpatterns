using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTests
{
    public class Data_Numbers_Tests
    {
        [Fact(DisplayName = "Numbers.GetList - Se retorna elementos")]
        public void Numbers_GetList()
        {
            // Arrange
            var nums = new Data.Numbers();

            // Act
            var result = nums.GetList();

            // Assert
            Assert.True(result != null, "No hay colección de datos");
            Assert.NotEmpty(result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(9)]
        public void Numbers_IsOdd(int num)
        {
            // Arrange
            var nums = new Data.Numbers();

            // Act
            var result = nums.IsOdd(num);

            // Assert
            Assert.True(result, $"¡El número {num} no es impar😜!");
        }
    }
}
