namespace ConsoleApp33
{

class Program
{
    public static void Main()
    {
        List<Price> products = new List<Price>
        {
            new Phone(300m, 12),
            new Phone(500m, 24), 
            new Laptop(1000m),  
        };

        decimal totalCost = 0;

        foreach (var product in products)
        {
            totalCost += product.GetPrice();

            if (product is Garranty warrantyProduct)
            {
                Console.WriteLine($"Гарантия {warrantyProduct.GetGarranty()} месяцев");
            }
        }

        Console.WriteLine($"Общая стоимость: {totalCost}");
    }
}
}