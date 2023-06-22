var products = new List<Product>();

var option = 0;
do
{
    //Console.Clear();
    Console.WriteLine("Opción: 1. Create, 2. List, 3.Update, 4. Delete, 5. Exit\n\n");
    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            var id = new Random().Next(1, 100);
            products.Add(new Product() { Id = id, Name = $"Product {id.ToString()}", Price = 100 * id });
            break;
        case 2:
            Console.WriteLine("Listado de productos");
            foreach (var p in products)
            {
                Console.WriteLine($"\nDetalle de producto");
                Console.WriteLine($"\t{p.Id} {p.Name} {p.Price}");
            }
            break;
        case 3:
            var idRamdom = new Random().Next(products.Min(p => p.Id), products.Min(p => p.Id));
            var product = products.Single(p => p.Id == idRamdom);
            product.Price *= 1.5f;

            break;
        case 4:
            Console.WriteLine($"Digite ID del producto a eliminar");
            var idDel = Convert.ToInt32(Console.ReadLine());

            // LINQ
            products.Remove(products.Single(p => p.Id == idDel));
            break;
        default:
            break;
    }

} while (option != 5);


Console.WriteLine("READY!");

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
}