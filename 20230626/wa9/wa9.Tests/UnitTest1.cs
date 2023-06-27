using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using wa9.Controllers;

namespace wa9.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IndexRetornaListaDeNúmeros()
        {
            // Arrange
            ILogger<HomeController> logger = Mock.Of<ILogger<HomeController>>();

            // Objeto simulado
            var mockNum = new Mock<Data.IGetList<int>>();
            mockNum.Setup(repo => repo.GetList())
                .Returns(new List<int>() { 2, 46, 3, 6, 9, 2, 34, 67, 89, 202, 304 });

            var controller = new HomeController(logger, mockNum.Object);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<int>>(viewResult.Model);
            Assert.Equal(11, model.Count());
        }
    }
}