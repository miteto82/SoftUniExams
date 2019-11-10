using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int videoCarts = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double moneyVideoCarts = videoCarts * 250;
            double Processors = (moneyVideoCarts * 0.35) * processor;
            double Rams = (moneyVideoCarts * 0.1) * ram;

            double sum = moneyVideoCarts + Processors + Rams;

            if(videoCarts > processor)
            {
                sum *= 0.85;
            }

            if(budjet - sum >= 0)
            {
                Console.WriteLine($"You have {budjet-sum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budjet-sum):f2} leva more!");
            }


        }
    }
}
