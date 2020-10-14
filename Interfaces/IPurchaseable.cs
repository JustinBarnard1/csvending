namespace Vending.Interfaces
{
    interface IPurchaseable
    {
        double Price { get; }
        string Name { get; set; }
        string SKU { get; set; }

        double CalculateCost();
    }
}