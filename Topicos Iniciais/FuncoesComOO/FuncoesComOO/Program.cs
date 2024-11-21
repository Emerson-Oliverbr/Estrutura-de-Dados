using FuncoesComOO;
using System;
using System.Globalization;

namespace FuncoesComOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product produto1 = new Product("Laptop", 1000.00, 5);
            Product produto2 = new Product("Headphones", 200.00, 2);

            double total1 = produto1.total();
            double total2 = produto2.total();

            Console.WriteLine($" R${total1.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($" R${total2.ToString("F2", CultureInfo.InvariantCulture)}");

            produto1.updatePrice(20.0);

            Console.WriteLine($" R${produto1.Price.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
