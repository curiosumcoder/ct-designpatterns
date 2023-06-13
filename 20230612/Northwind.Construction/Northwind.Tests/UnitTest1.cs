using Northwind.AbstractFactory;
using Northwind.Data;
using Northwind.FactoryMethod;
using Northwind.Model;
using Northwind.Singleton;

namespace Northwind.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void BasicContruction_Test()
        {
            // Arrange
            var pD = new ProductExportD();
            var pD2 = new ProductImportD();

            // Arrange 2
            ProductTypes pt = ProductTypes.Import;

            IWrite pW = null;

            switch (pt)
            {
                case ProductTypes.Export:
                    pW = new ProductExportD();
                    break;
                case ProductTypes.Import:
                    pW = new ProductImportD();
                    break;
            }

            pW?.Create(new Product());
        }


        [Fact]
        public void SimpleFactoryContruction_Test()
        {
            var factory = new SimpleFactory.SimpleProductDFactory();
            IWrite pD = factory.CreateProductD(ProductTypes.Export);

            pD.Create(new Product());
        }

        [Fact]
        public void FactoryMethodContruction_Test()
        {
            Creator factory = new ProductDImportCreator();

            IWrite pD = factory.CreateProductD();

            pD?.Create(new Product());
        }

        [Fact]
        public void AbstractFactoryContruction_Test()
        {
            IAbstractFactory factory = new ProductDatabaseCreator();

            IWrite pD = factory.CreateProductExportD();

            pD?.Create(new Product());
        }

        [Fact]
        public void SingletonContruction_Test()
        {
            //var counter = new MyCounter();
            var counter = MyCounter.Instance;
            //counter = MyCounter.Instance;

            counter.Value++;
            counter.Value++;
        }
    }
}