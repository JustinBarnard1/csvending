namespace Vending.Interfaces
{
    interface IPurchaseable
    {
        double Price { get; }

        double CalculateCost();
    }
}