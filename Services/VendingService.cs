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




        internal bool GetSnacks()
        {
            throw new NotImplementedException();
        }

        internal bool Buy(int v)
        {
            throw new NotImplementedException();
        }

        internal bool GetInfo(int v)
        {
            throw new NotImplementedException();
        }
    }
}