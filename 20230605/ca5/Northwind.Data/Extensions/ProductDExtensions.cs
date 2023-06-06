using System.Text;

namespace Northwind.Data.Extensions
{
    /// <summary>
    /// OCP
    /// </summary>
    public static class ProductDExtensions
    {
        public static string ListAsCSV(this ProductD pD)
        {
            var data = pD.List();

            var csv = new StringBuilder();

            foreach (var p in data)
            {
                csv.AppendLine($"{p.Id}, {p.Name}, {p.Price}");
            }

            return csv.ToString();
        }
    }
}
