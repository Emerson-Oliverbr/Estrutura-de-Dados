using System;

namespace TiposEstruturados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product produto1 = new Product("Laptop", 1000.00, 5);
            Product produto2 = new Product("Headphones", 200.00, 2);

            Console.WriteLine($"{produto1}");
            Console.WriteLine($"{produto2}");
            Console.WriteLine($"{produto1.Name}");
            Console.WriteLine($"{produto2.Name}");
        }
    }
}
