using Vending.Interfaces;

namespace Vending.Models
{
    class Snack : IPurchaseable
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }


        public double CalculateCost()
        {
            return Price;
        }

        public Snack(double price, string name, string sku)
        {
            Price = price;
            Name = name;
            SKU = sku;
        }
    }
}