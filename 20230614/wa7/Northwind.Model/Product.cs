using System.ComponentModel.DataAnnotations;

namespace Northwind.Model
{
    public class Product
    {
        public int Id { get; set; }

        // attribute
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El precio es requerido")]
        public decimal Price { get; set; }
    }
}