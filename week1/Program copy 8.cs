using System;

namespace AgeDeterminer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string result = age switch
            {
                var x when x >= 0 && x <= 12 => "a child",
                var x when x >= 13 && x <= 19 => "a teenager",
                var x when x >= 20 && x <= 150 => "an adult",
                _ => "invalid",
            };

            Console.WriteLine("Age " + age + ": " + result);
        }
    }
}
