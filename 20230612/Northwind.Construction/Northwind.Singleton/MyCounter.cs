namespace Northwind.Singleton
{
    public class MyCounter
    {
        private MyCounter() { }

        public uint Value { get; set; } = 0;

        private static MyCounter _instance;

        public static MyCounter Instance
        {
            get {
                if (_instance == null)
                { 
                    _instance = new MyCounter();
                }
                
                return _instance; 
            }
        }
    }
}