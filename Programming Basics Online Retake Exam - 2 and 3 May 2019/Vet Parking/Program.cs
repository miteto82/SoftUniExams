using System;

namespace Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sumMoney = 0.0;
            double moneyPerDay = 0.0;

            for (int i = 1; i <= days; i++)
            {
                if(i % 2 == 1)
                {
                    for (int j = 1; j <= hours; j++)
                    {
                        if(j % 2 == 1)
                        {
                            sumMoney += 1;
                            moneyPerDay += 1;
                        }
                        else
                        {
                            sumMoney += 1.25;
                            moneyPerDay += 1.25;
                        }
                    }

                    Console.WriteLine($"Day: {i} - {moneyPerDay:f2} leva");
                    moneyPerDay = 0;
                }
                else
                {
                    for (int j = 1; j <= hours; j++)
                    {
                        if (j % 2 == 1)
                        {
                            sumMoney += 2.5; 
                            moneyPerDay += 2.5;
                        }
                        else
                        {
                            sumMoney += 1;
                            moneyPerDay += 1;
                        }
                    }

                    Console.WriteLine($"Day: {i} - {moneyPerDay:f2} leva");
                    moneyPerDay = 0;
                }
                
            }

            Console.WriteLine($"Total: {sumMoney:f2} leva");
        }
    }
}
