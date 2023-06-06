namespace Northwind.Model
{
    /// <summary>
    /// SRP
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public virtual string Details()        
        {
            return $"{Id}, {Name}, {Price}";
        }
    }
}
