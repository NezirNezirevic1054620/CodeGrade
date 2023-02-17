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

            string season = month switch
            {
                int m when (m < 3 || (m == 3 && day < 21) || m == 12 && day >= 21) => "winter",
                int m when (m < 6 || (m == 6 && day < 21)) => "spring",
                int m when (m < 9 || (m == 9 && day < 21)) => "summer",
                int m when (m < 12 || (m == 12 && day < 21)) => "autumn",
                _ => string.Empty
            };

            Console.WriteLine("On " + day + "-" + month + " it is " + season);
        }
    }
}
