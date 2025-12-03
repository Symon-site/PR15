using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Vent: Turnable
    {
    
    public bool IsOn { get; private set; }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("Вентилятор выключен!");
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("Вентилятор включен!");
    }

    public void ShowState()
    {
        Console.WriteLine($"Вентилятор: {(IsOn ? "Включен" : "Выключен")}");
    }
    
    }
}
