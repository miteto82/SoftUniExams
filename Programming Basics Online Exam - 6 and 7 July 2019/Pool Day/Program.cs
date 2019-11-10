using System;

namespace Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double taxIN = double.Parse(Console.ReadLine());
            double bedTax = double.Parse(Console.ReadLine());
            double ambrelaTax = double.Parse(Console.ReadLine());

            double sumTax = 0.0;
            double peopleBed = Math.Ceiling(people * 0.75);

            sumTax = people * taxIN;
            sumTax += peopleBed * bedTax;
            sumTax += Math.Ceiling(people / 2) * ambrelaTax;

            Console.WriteLine($"{sumTax:f2} lv.");


        }
    }
}
