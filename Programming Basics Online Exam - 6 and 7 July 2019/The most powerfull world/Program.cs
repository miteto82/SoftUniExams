using System;

namespace The_most_powerfull_world
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double maxPowerPoints = -100;
            string theWord = "";
            

            while (input != "End of words")
            {
                string word = input;
                double sum = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    sum += (double)word[i];
                }

                    if(word[0] == 'A' || word[0] == 'E' || word[0] == 'O' || word[0] == 'U' || word[0] == 'Y' || word[0] == 'I'
                    || word[0] == 'a' || word[0] == 'e' || word[0] == 'o' || word[0] == 'u' || word[0] == 'y' || word[0] == 'i')
                    {
                        sum *= word.Length;
                    }
                    else
                    {
                        Math.Floor(sum /= word.Length);
                    }

                    if(maxPowerPoints < sum)
                    {
                        maxPowerPoints = sum;
                        theWord = word;
                    }

                    input = Console.ReadLine();
                
            }

            Console.WriteLine($"The most powerful word is {theWord} - {maxPowerPoints}");
        }
    }
}
