using System;
using System.Collections.Generic;
using Vending.Interfaces;
using Vending.Models;

namespace Vending.Services
{
    class VendingService
    {
        public List<IPurchaseable> Purchasables { get; set; }

        public List<Snack> Snacks { get; set; }
        public List<Sweet> Sweets { get; set; }
        public List<Salty> Salties { get; set; }




        internal string GetSnacks(bool wantSweet)
        {
            if (wantSweet)
            {
                var list = "Choose from the following: \n";
                var items = Purchasables.FindAll(s => s is Sweet);
                for (int i = 0; i < items.Count; i++)
                {
                    IPurchaseable item = items[i];
                    list += $"{i + 1}. {item.Name} - ${item.Price}\n";
                }
                return list;
            }
            else
            {
                var list = "Choose from the following: \n";
                var items = Purchasables.FindAll(s => s is Salty);
                for (int i = 0; i < items.Count; i++)
                {
                    IPurchaseable item = items[i];
                    list += $"{i + 1}. {item.Name} - ${item.Price}\n";
                }
                return list;
            }
        }

        internal string Buy(int index)
        {
            return "Enjoy your snack";
        }




        public VendingService()
        {
            Purchasables = new List<IPurchaseable>(){
            new Sweet(2, "Snickers", true),
            new Sweet(1.75, "Almond Joy", true),
            new Sweet(1, "Twizzlers", true),
            new Salty(1, "Popcorn", true),
            new Salty(1.25, "Lays Sour Cream And Onion", true),
            new Salty(1.25, "Salted Peanuts", true)
        };
        }
    }
}