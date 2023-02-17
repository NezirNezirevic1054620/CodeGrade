using System;

namespace OrigamiFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = "";
            int number = 0;

            while (!(color == "red" || color == "blue" || color == "green" || color == "yellow"))
            {
                Console.WriteLine("Pick a color (red/blue/green/yellow):");
                color = Console.ReadLine().ToLower();
            }

            while (number < 1 || number > 8)
            {
                Console.WriteLine("Pick a number (1-8):");
                number = int.Parse(Console.ReadLine());
            }

            int colorLength = color.Length;
            int fortuneNumber = (number + colorLength) % 4 + 1;

            PrintFortune(fortuneNumber);
        }

        static void PrintFortune(int fortuneNumber)
        {
            string fortune = fortuneNumber switch
            {
                1 => "You will be loved and be happy!",
                2 => "You will be loved and be rich!",
                3 => "You will be loved and be famous!",
                4 => "You will be loved, and you'll be happy, rich and famous!",
                _ => "Unknown. :( But you will still be loved, no matter what."
            };
            Console.WriteLine(fortune);
        }
    }
}
