using Northwind.Data;
using Northwind.Model;

namespace Northwind.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CommandPattern_Test()
        {
            // Arrange
            var p = new Product() { Id = 1, Name = "Chai", Price = 100 };
            var pD = new ProductD();

            // Comandos
            var createComm = new ProductCreateCommand(pD, p);
            var updateComm = new ProductUpdateCommand(pD, p);

            // Invocador
            var invoker = new DataCommandInvoker(createComm);

            // Cambio de comportamiento
            invoker.ChangeCommand(updateComm);

            invoker.ExecuteCommand();
        }

        [Fact]
        public void ObserverPattern_Test()
        {
            // Arrange
            var p = new Product() { Id = 1, Name = "Chai", Price = 100 };

            var pObservable = new ProductSubject();
            pObservable.PriceChange(p);

            IObserver ob1 = new Observer();
            IObserver ob2 = new Observer();
            IObserver ob3 = new Observer();

            pObservable.RegisterObserver(ob1);
            pObservable.RegisterObserver(ob2);
            pObservable.RegisterObserver(ob3);

            p.Price = 123;
            pObservable.PriceChange(p);

            p.Price *= 2.5;
            pObservable.PriceChange(p);
        }
    }
}