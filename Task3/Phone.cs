using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Phone: Price, Garranty
    {
        private decimal price;
        private int garranty;

        public Phone(decimal price, int garrantyMonths)
        {
            this.garranty = garrantyMonths;
            this.price = price;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public int GetGarranty()
        {
            return garranty;
        }
    }
}
