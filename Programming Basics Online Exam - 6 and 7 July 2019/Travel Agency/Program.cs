using System;

namespace Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string package = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = 0.0;
            double VipPrice = 0.0;
            

            if(days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            

            if(town == "Bansko" || town == "Borovets")
            {
                if(package == "withEquipment")
                {
                    price = 100;
                    VipPrice = price * 0.9;
                }
                else if(package == "noEquipment")
                {
                    price = 80;
                    VipPrice = price * 0.95;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else if(town == "Varna" || town == "Burgas")
            {
                if(package == "withBreakfast")
                {
                    price = 130;
                    VipPrice = price * 0.88;
                }
                else if(package == "noBreakfast")
                {
                    price = 100;
                    VipPrice = price * 0.93;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            if(vip == "yes")
            {
                price = VipPrice;
            }
            if (days > 7)
            {
                days -= 1;
            }
            Console.WriteLine($"The price is {price*days:f2}lv! Have a nice time!");

        }
    }
}
