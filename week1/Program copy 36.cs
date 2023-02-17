using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{

    class TemperatureConversion
    {

        static void Main(string[] args)
        {
            double fahrenheit;

            Console.Write("What is the temperature in Celsius? ");
            double celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine(celsius + " C = " + fahrenheit + " F");
            Console.WriteLine("Rounded down that is " + Convert.ToInt32(Math.Floor(fahrenheit)) + " F");

            Console.ReadLine();
        }
    }
}