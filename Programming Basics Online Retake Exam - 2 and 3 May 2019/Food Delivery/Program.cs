using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double veganMenu = double.Parse(Console.ReadLine());

            double totalPriceMenu = chickenMenu * 10.35 + fishMenu * 12.40 + veganMenu * 8.15;

            double desert = totalPriceMenu * 0.2;

            double delivery = 2.5;

            double totalPrice = totalPriceMenu + desert + delivery;

            Console.WriteLine($"Total: {totalPrice:f2}");
        }
    }
}
