using Vending.Interfaces;

namespace Vending.Models
{
    class Snack : IPurchaseable
    {
        public Snack(double price, string name)
        {
            Price = price;
            Name = name;
        }
        public double Price { get; set; }
        public string Name { get; set; }


        public double CalculateCost()
        {
            return Price;
        }
    }
}