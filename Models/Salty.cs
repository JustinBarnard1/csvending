namespace Vending.Models
{
    class Salty : Snack
    {
        public Salty(double price, string name, bool issalty) : base(price, name)
        {
            Price = price;
            Name = name;
            isSalty = issalty;
        }

        public bool isSalty { get; set; }
    }
}