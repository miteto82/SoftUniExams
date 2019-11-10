using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int persent = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double area = x * y * 4;
            area = area - (area / 100 * persent);

            while (input != "Tired!")
            {
                int paint = int.Parse(input);
                area -= paint;

                if(area < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(area)} l paint left!");
                    return;
                }
                else if(area == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{area} quadratic m left.");
        }
    }
}
