using System;

namespace PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double percentH = 0.0;
            double percentF = 0.0;
            double percentO = 0.0;
            double percent = 0.0;
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;

            for (int i = 0; i < n; i++)
            {
                string game = Console.ReadLine();


                switch (game)
                {
                    case "Hearthstone":
                        percentH = (100 / n) * ++a;
                        break;
                    case "Fornite":
                        percentF = (100 / n) * ++b;
                        break;
                    case "Overwatch":
                        percentO = (100 / n) * ++c;
                        break;
                    default:
                        percent = (100 / n) * ++d;
                        break;
                }
            }

            Console.WriteLine($"Hearthstone - {percentH:f2}%");
            Console.WriteLine($"Fornite - {percentF:f2}%");
            Console.WriteLine($"Overwatch - {percentO:f2}%");
            Console.WriteLine($"Others - {percent:f2}%");
        }
    }
}
