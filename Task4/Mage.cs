using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Mage: Atack, Healing
    {
        public void atack()
        {
            Console.WriteLine("Маг атакует");
        }

        public void hill()
        {
            Console.WriteLine("Маг лечит");
        }
    }
}
