namespace ConsoleApp32
{
    class Program
    {
        static void Main()
        {
            Lamp lampa = new Lamp();
            Vent ventilyator = new Vent();

            lampa.TurnOn();
            lampa.SetLevel(50);
            lampa.ShowState();
            lampa.TurnOff();
            lampa.ShowState();

            ventilyator.TurnOn();
            ventilyator.ShowState();
            ventilyator.TurnOff();
            ventilyator.ShowState();
        }
    }
}
