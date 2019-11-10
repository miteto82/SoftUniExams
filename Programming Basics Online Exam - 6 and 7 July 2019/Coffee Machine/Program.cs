using System;

namespace Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coffee = Console.ReadLine();
            string shugar = Console.ReadLine();
            int countCoffee = int.Parse(Console.ReadLine());

            double price = 0.0;

            if(coffee == "Espresso")
            {
                switch (shugar)
                {
                    case "Without":
                        price = 0.90;
                        break;
                    case "Normal":
                        price = 1.00;
                        break;
                    case "Extra":
                        price = 1.20;
                        break;
                    default:
                        break;
                }
            }
            else if(coffee == "Cappuccino")
            {
                switch (shugar)
                {
                    case "Without":
                        price = 1.00;
                        break;
                    case "Normal":
                        price = 1.20;
                        break;
                    case "Extra":
                        price = 1.60;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (shugar)
                {
                    case "Without":
                        price = 0.50;
                        break;
                    case "Normal":
                        price = 0.60;
                        break;
                    case "Extra":
                        price = 0.70;
                        break;
                    default:
                        break;
                }
            }

            price *= countCoffee;

            if(shugar == "Without")
            {
                price *= 0.65;
            }
            if(coffee == "Espresso" && countCoffee >= 5)
            {
                price *= 0.75;
            }
            if(price > 15)
            {
                price *= 0.80;
            }

            Console.WriteLine($"You bought {countCoffee} cups of {coffee} for {price:f2} lv.");
        }
    }
}
