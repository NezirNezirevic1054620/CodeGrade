using System;

namespace BankPasswordVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "1234";
            int attempts = 3;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your PIN");
                Console.WriteLine(attempts - i + " attempts left");
                string userInput = Console.ReadLine();

                if (userInput == correctPassword)
                {
                    Console.WriteLine("Correct!");
                    return;
                }
            }
            Console.WriteLine("Your pass is confiscated.");
        }
    }
}
