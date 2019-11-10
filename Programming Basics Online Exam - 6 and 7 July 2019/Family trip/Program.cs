using System;

namespace Family_trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double spendMoney = nights * priceNight;

            if(nights > 7)
            {
                spendMoney *= 0.95; 
            }

            spendMoney += (budjet / 100) * percent;
            double money = budjet - spendMoney;

            if (money >= 0)
            {
                Console.WriteLine($"Ivanovi will be left with {money:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(money):f2} leva needed.");
            }
        }
    }
}
