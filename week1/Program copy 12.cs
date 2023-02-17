using System;

namespace SecondsConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            double seconds = Convert.ToInt32(Console.ReadLine());

            double hours = seconds / 3600;
            double minutes = (seconds % 3600) / 60;
            double remaining_seconds = seconds % 60;
            Console.WriteLine("Hours: " + Math.Floor(hours));
            Console.WriteLine("Minutes: " + Math.Floor(minutes));
            Console.WriteLine("Seconds left: " + remaining_seconds);


        }
    }
}
