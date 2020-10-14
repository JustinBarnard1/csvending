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
            Console.WriteLine("Type (V)end to purchase or (I)nfo for pricing");
            string input = Console.ReadLine().ToLower();
            Console.Clear();
            switch (input)
            {
                case "v":
                case "vend":
                    Buy();
                    break;
                case "i":
                case "info":
                    Info();
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }

        private void Buy()
        {
            Console.WriteLine(_Service.GetSnacks());
            Console.Write("Enter a number to buy: ");
            string inputStr = Console.ReadLine();
            if (int.TryParse(inputStr, out int index) && index > 0)
            {
                Console.WriteLine("Vending...");
                Thread.Sleep(500);
                Console.WriteLine(_Service.Buy(index - 1));
                Console.Clear();
            }
        }
        private void Info()
        {
            Console.WriteLine(_Service.GetSnacks());
            Console.Write("Enter a number to get its info: ");
            string inputStr = Console.ReadLine();
            if (int.TryParse(inputStr, out int index) && index > 0)
            {
                Console.WriteLine(_Service.GetInfo(index - 1));
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}