using System;

namespace WordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string targetWord = "length";
            Console.WriteLine("You have one chance to guess this six-letter word:");
            Console.WriteLine("Le..th");
            Console.WriteLine("HINT: this word is used to find the LENGTH of a string!");

            string guess = Console.ReadLine();
            if (guess.Length != 6)
            {
                Console.WriteLine("Incorrect! That is not even a six-letter word!");
            }
            else if (guess.ToLower() == targetWord)
            {
                Console.WriteLine("Correct!");
            }
            else if (guess.ToLower() != targetWord && guess.Length == 6)
            {
                Console.WriteLine("Kind of correct; the case was just wrong");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }
    }
}
