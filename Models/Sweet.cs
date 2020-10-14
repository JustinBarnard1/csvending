namespace Vending.Models
{
    class Sweet : Snack
    {
        public Sweet(double price, string name, bool issweet) : base(price, name)
        {
            Price = price;
            Name = name;
            isSweet = issweet;
        }

        public bool isSweet { get; set; }
    }
}