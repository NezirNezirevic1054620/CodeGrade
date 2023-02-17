// Type your username and press enter
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please enter your last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is the initial of your first name?");
            char firstInitial = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Welcome to the course, " + firstInitial + " " + lastName + ". We will watch your career with great interest.");
        }
    }
}
