using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Lamp: Turnable, LevelAdaptable
    {
            private bool isOn;
    private int level;
    public bool IsOn => isOn;
    public int Level => level;

    public Lamp()
    {
        isOn = false;
        level = 0;
    }

    public void TurnOn()
    {
        isOn = true;
        level = 100;
        Console.WriteLine("Лампа включена");
    }

    public void TurnOff()
    {
        isOn = false;
        level = 0;
        Console.WriteLine("Лампа выключена");
    }

    public void SetLevel(int level)
    {
        level = level < 0 ? 0 : level > 100 ? 100 : level;
        Console.WriteLine($"Яркость лампы: {level}%");
    }

    public void ShowState()
    {
        Console.WriteLine($"Лампа: {(isOn ? "Включена" : "Выключена")}; уровень: {level}%");
    }
}
    
}
