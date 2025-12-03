using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Robot: Worker, Charger
    {
        public int EnergyLevel { get; set; }
        public string Name { get; set; }
        public Robot(string name)
        {
            Name = name;
            EnergyLevel = 100;
        }
        public void Work()
        {
            if (EnergyLevel > 0)
            {
                EnergyLevel = Math.Max(0, EnergyLevel - 20);
                Console.WriteLine($"{Name} функционирует; текущая энергия: {EnergyLevel}");

            }
            else
            {
                Console.WriteLine($"{Name} разряжен");
            }
        }
        public void Charger()
        {
            EnergyLevel = 100;
            Console.WriteLine($"{Name} заряжен");
        }
    }
}
