using System;


namespace App
{

    class WaterStateWatching
    {

        static void Main(string[] args)
        { 

            Console.Write("What is the temperature of the water? (Celsius) ");
            double celsius =double.Parse(Console.ReadLine());

            
            if (celsius == 0)
            {
                Console.Write("At " + celsius + " degrees Celsius, the water will be solid");
            }
            else if (celsius <= 99.9)
            {
                Console.Write("At " + celsius + " degrees Celsius, the water will be liquid");
            }
            else if (celsius >= 100)
            {
                Console.Write("At " + celsius + " degrees Celsius, the water will be gas");
            }
        }
    }
}