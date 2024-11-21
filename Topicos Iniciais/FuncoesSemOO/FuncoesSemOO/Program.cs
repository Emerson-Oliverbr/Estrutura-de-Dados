using FuncoesSemOO;
using System;
using System.Globalization;

namespace FuncoesSemOO
{
    internal class Program
    {
        static double total(Product product)
        {
            return product.Price * product.Quantity;
        }

        static void updatePrice(Product product, double percentage )
        {
            product.Price = product.Price * (1 + percentage / 100.0);
        }
        static void Main(string[] args)
        {
            Product produto1 = new Product("Laptop", 1000.00, 5);
            Product produto2 = new Product("Headphones", 200.00, 2);

            double totalProduct1 = total(produto1);
            double totalProduct2 = total(produto2);

            Console.WriteLine($" R${totalProduct1.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($" R${totalProduct2.ToString("F2", CultureInfo.InvariantCulture)}");

            updatePrice(produto1, 20.0);

            Console.WriteLine($" R${produto1.Price.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
