namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        var product1 = ProductFactory.GetProduct("Keyboard");
        Console.WriteLine($"Retrieved {product1.Name}, it costs ${product1.Price}");
        
        var product2 = ProductFactory.GetProduct("Monitor");
        Console.WriteLine($"Retrieved {product2.Name}, it costs ${product2.Price}");
    }

    public interface IProduct
    {
        public string Name { get; }
        public decimal Price { get; }
    }

    public class Keyboard : IProduct
    {
        public string Name { get; } = "Keyboard";

        public decimal Price { get; } = 19.99m;
    }

    public class Monitor : IProduct
    {
        public string Name { get; } = "Monitor";

        public decimal Price { get; } = 299.99m;
    }

    public class ProductFactory
    {
        public static IProduct GetProduct(string name)
        {
            switch(name.ToLower())
            {
                case "keyboard":
                    return new Keyboard();
                    break;
                case "monitor":
                    return new Monitor();
                    break;
                default:
                    throw new ArgumentException("Unknown product name", name);
            }
        }
    }
}