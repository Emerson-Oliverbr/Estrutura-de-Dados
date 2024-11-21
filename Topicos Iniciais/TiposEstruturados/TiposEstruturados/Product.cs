using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace TiposEstruturados
{
    internal class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product (string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name}, Preço = R$ {Price.ToString("F2",CultureInfo.InvariantCulture)}, Quantidade = {Quantity}";
        }
    }
}
