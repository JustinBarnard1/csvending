namespace Vending.Interfaces
{
    interface IPurchaseable
    {
        double Price { get; }
        string Name { get; set; }

        double CalculateCost();
    }
}