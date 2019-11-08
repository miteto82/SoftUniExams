using System;

namespace Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }

            double persent1 = (100 * p1) / n;
            double persent2 = (100 * p2) / n;
            double persent3 = (100 * p3) / n;

            Console.WriteLine($"{persent1:f2}%");
            Console.WriteLine($"{persent2:f2}%");
            Console.WriteLine($"{persent3:f2}%");
        }
    }
}
