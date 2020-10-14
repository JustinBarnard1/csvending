using System;
using System.Threading;
using Vending.Services;

namespace Vending.Controllers
{
    class VendingController
    {
        private VendingService _Service { get; set; } = new VendingService();
        public bool _Running { get; set; } = true;
        public void Run()
        {
            while (_Running)
            {
                GetUserInput();
            }
        }

        private void GetUserInput()
        {
            Console.WriteLine("Type (V)end to purchase or (e)nd to leave this service: ");
            string input = Console.ReadLine().ToLower();
            Console.Clear();
            switch (input)
            {
                case "v":
                case "vend":
                    Vend();
                    break;
                case "e":
                case "end":
                    Info();
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }

        private void Vend()
        {
            Console.Write("Do you want to buy a (sw)eet or (sa)lty snack: ");
            string inputCategory = Console.ReadLine().ToLower();
            Console.Clear();

            switch (inputCategory)
            {
                case "sweet":
                case "sw":
                    BuySweet();
                    break;
                case "salty":
                case "sa":
                    BuySalty();
                    break;
                case "end":
                    Info();
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;

            }
        }

        private void BuySweet()
        {
            Console.WriteLine(_Service.GetSnacks(true));
            Console.Write("Enter a number to choose your snack: ");
            string inputStr = Console.ReadLine();
            if (int.TryParse(inputStr, out int index) && index > 0)
            {
                Console.WriteLine("Vending...");
                Thread.Sleep(8000);
                Console.WriteLine(_Service.Buy(index - 1));
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        private void BuySalty()
        {
            Console.WriteLine(_Service.GetSnacks(false));
            Console.Write("Enter a number to choose your snack: ");
            string inputStr = Console.ReadLine();
            if (int.TryParse(inputStr, out int index) && index > 0)
            {
                Console.WriteLine("Vending...");
                Thread.Sleep(8000);
                Console.WriteLine(_Service.Buy(index - 1));
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        private void Info()
        {
            Console.WriteLine("Thank you for using this service! Come Again!");
            Thread.Sleep(2000);
            Console.Clear();
            _Running = false;
        }
    }
}