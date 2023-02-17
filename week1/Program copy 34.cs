using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to play Guess The Number!");
            bool playAgain = true;
            while (playAgain)
            {
                Console.Write("Give the minimum number: ");
                int min = int.Parse(Console.ReadLine());
                Console.Write("Give the maximum number: ");
                int max = int.Parse(Console.ReadLine());

                if (min == max)
                {
                    max++;
                }
                else if (min > max)
                {
                    int temp = min;
                    min = max;
                    max = temp;
                }

                Random random = new Random();
                int target = random.Next(min, max + 1);
                Console.WriteLine("Guess the number [" + min + "-" + max + "]");

                bool guessedCorrectly = false;
                while (!guessedCorrectly)
                {
                    int guess = int.Parse(Console.ReadLine());
                    if (guess < target)
                    {
                        Console.WriteLine("Higher!");
                    }
                    else if (guess > target)
                    {
                        Console.WriteLine("Lower!");
                    }
                    else
                    {
                        Console.WriteLine(guess + " is correct!");
                        guessedCorrectly = true;
                    }
                }

                Console.Write("Do you wish to play another round? Y to continue ");
                string response = Console.ReadLine();
                if (response != "y" && response != "Y")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thank you for playing!");
        }
    }
}
