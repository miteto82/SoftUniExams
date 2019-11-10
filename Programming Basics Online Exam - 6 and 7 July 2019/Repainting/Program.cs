using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            nylon = (nylon + 2) * 1.5;
            paint *= 1.10;
            paint *= 14.5;
            diluent *= 5;

            double sumMoney = nylon + paint + diluent + 0.4;
            double work = sumMoney * 0.3 * hours + sumMoney;

            Console.WriteLine($"Total expenses: {work:f2} lv.");
        }
    }
}
