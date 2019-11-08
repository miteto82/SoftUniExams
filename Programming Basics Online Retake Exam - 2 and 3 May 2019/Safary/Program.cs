using System;

namespace Safary
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double gasoline = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double gasolinePrice = gasoline * 2.1;
            double moneySpend = gasolinePrice + 100;

            if(day == "Sunday")
            {
                moneySpend *= 0.8;
            }
            else
            {
                moneySpend *= 0.9;
            }

            double isEnought = budget - moneySpend;

            if(isEnought >= 0)
            {
                Console.WriteLine($"Safari time! Money left: {isEnought:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {Math.Abs(isEnought):f2} lv.");
            }

            
        }
    }
}
