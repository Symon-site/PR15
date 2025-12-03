using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Laptop: Price
    {
        private decimal price;

        public Laptop(decimal price)
        {
            this.price = price;
        }

        public decimal GetPrice()
        {
            return price;
        }
    }
}
