using System;

namespace Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());
            int points = 0;
            int counterW = 0;
            int counterD = 0;
            int counterL = 0;

            if (n == 0)
            {
                Console.WriteLine($"{Name} hasn't played any games during this season.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                char action = char.Parse(Console.ReadLine());

                switch (action)
                {
                    case 'W':
                        points += 3;
                        counterW++;
                        break;
                    case 'D':
                        points += 1;
                        counterD++;
                        break;
                    case 'L':
                        points += 0;
                        counterL++;
                        break;
                    default:
                        break;
                }
            }

            double winRates = (100 / n) * counterW;

            Console.WriteLine($"{Name} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {counterW}");
            Console.WriteLine($"## D: {counterD}");
            Console.WriteLine($"## L: {counterL}");
            Console.WriteLine($"Win rate: {winRates:f2}%");
        }
    }
}
