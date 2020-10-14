using System;
using Vending.Controllers;

namespace Vending
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            new VendingController().Run();
        }
    }
}
