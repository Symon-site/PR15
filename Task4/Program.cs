namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atack warrior = new Warrior();
            Atack mage = new Mage();
            Healing mageHealing = (Healing)mage;

            Console.WriteLine("Кто могут атаковать: ");
            warrior.atack();
            mage.atack();
            Console.WriteLine();
            Console.WriteLine("Кто умеют лечить: ");
            mageHealing.hill();
        }
    }
}