using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Console.WriteLine("What is the person's name?");
        string name = Console.ReadLine();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Happy birthday to you!");
            if (i == 1)
            {
                Console.WriteLine($"Happy birthday dear {name}!");
            }
        }
    }
}