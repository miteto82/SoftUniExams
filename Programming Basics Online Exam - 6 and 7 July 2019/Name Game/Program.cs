using System;

namespace Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int points = 0;
            int counter = 0;
            int maxPoints = 0;
            string winner = "";
            

            while (input != "Stop")
            {
                string name = input;
                counter++;

                for (int i = 0; i < name.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    int ascii = (int)(name[i]);

                    if (number == ascii)
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }

                if (maxPoints <= points)
                {
                    maxPoints = points;
                    points = 0;
                    winner = name;
                }
                else
                {
                    points = 0;
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"The winner is {winner} with {maxPoints} points!");
        }
    }
}
