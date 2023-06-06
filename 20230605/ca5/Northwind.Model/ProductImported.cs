namespace Northwind.Model
{
    /// <summary>
    /// LSP
    /// </summary>
    public class ProductImported : Product
    {
        public string Origin { get; set; }

        public override string Details()
        {
            //base.Details(); // Llamando al padre

            return $"{Id}, {Name}, {Price}, {Origin}";
        }
    }
}
