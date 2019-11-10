using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double wishProfit = double.Parse(Console.ReadLine());
            double sumMoney = 0.0;
           

            while (wishProfit > 0)
            {
                string coctail = Console.ReadLine();

                if(coctail == "Party!")
                {
                    if(wishProfit >= 0)
                    {
                        Console.WriteLine($"We need {wishProfit:f2} leva more.");
                        Console.WriteLine($"Club income - {sumMoney:f2} leva.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Target acquired.");
                        Console.WriteLine($"Club income - {sumMoney:f2} leva.");
                        return;
                    }
                }
                double count = double.Parse(Console.ReadLine());
                double price = coctail.Length * count;

                if(price % 2 == 1)
                {
                    price *= 0.75;
                }

                sumMoney += price;
                wishProfit -= price;

            }

            Console.WriteLine("Target acquired.");
            Console.WriteLine($"Club income - {sumMoney:f2} leva.");
        }
    }
}
