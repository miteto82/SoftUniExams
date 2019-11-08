using System;

namespace Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int counter = 0;
            double sumMoney = 0.0;

            while (budjet >= 0)
            {
                string nameProduct = Console.ReadLine();
                if (nameProduct == "Stop")
                {
                    Console.WriteLine($"You bought {counter} products for {sumMoney:f2} leva.");
                    return;
                }
                double priseProduct = double.Parse(Console.ReadLine());
                counter++;

                if(counter % 3 == 0)
                {
                    priseProduct /= 2;
                }

                budjet -= priseProduct;

                sumMoney += priseProduct;

                
            }

            Console.WriteLine("You don't have enough money!");
            Console.WriteLine($"You need {Math.Abs(budjet):f2} leva!");
        }
    }
}
