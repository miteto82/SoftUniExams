using System;

namespace Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeLimit = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string mobileInternet = Console.ReadLine();
            int mounths = int.Parse(Console.ReadLine());

            double price = 0.0;

            if(timeLimit == "one")
            {
                switch (typeContract)
                {
                    case "Small":
                        price = 9.98;
                        break;
                    case "Middle":
                        price = 18.99;
                        break;
                    case "Large":
                        price = 25.98;
                        break;
                    case "ExtraLarge":
                        price = 35.99;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                switch (typeContract)
                {
                    case "Small":
                        price = 8.58;
                        break;
                    case "Middle":
                        price = 17.09;
                        break;
                    case "Large":
                        price = 23.59;
                        break;
                    case "ExtraLarge":
                        price = 31.79;
                        break;

                    default:
                        break;
                }
            }


            if(mobileInternet == "yes")
            {
                if(price <= 10)
                {
                    price += 5.50;
                }
                else if(price > 10 && price <= 30)
                {
                    price += 4.35;
                }
                else
                {
                    price += 3.85;
                }

                
            }

            price *= mounths;

            if(timeLimit == "two")
            {
                price -= (price / 100) * 3.75;
                Console.WriteLine($"{price:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{price:f2} lv.");
            }

            

            
        }
    }
}
