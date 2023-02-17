using System;

namespace SeasonDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the month? 1-12");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the day? 1-31");
            int day = int.Parse(Console.ReadLine());

            if (month < 3 || (month == 3 && day < 21) || month == 12 && day >= 21)
            {
                Console.WriteLine("On " + day + "-" + month + " it is winter");
            }
            else if (month < 6 || (month == 6 && day < 21))
            {
                Console.WriteLine("On " + day + "-" + month + " it is spring");
            }
            else if (month < 9 || (month == 9 && day < 21))
            {
                Console.WriteLine("On " + day + "-" + month + " it is summer");
            }
            else if (month < 12 || (month == 12 && day < 21))
            {
                Console.WriteLine("On " + day + "-" + month + " it is autumn");
            }
        }
    }
}
