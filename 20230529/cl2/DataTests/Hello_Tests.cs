using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTests
{
    public class Hello_Tests
    {
        [Fact]
        public void SayHello_Test()
        {
            // Arrange
            bool varBool;

            // Act
            varBool = true;

            // Assert
            Assert.True(varBool, "No es verdadero.");
        }
    }
}
