using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            Console.WriteLine("What direction would you like to go?");
            Console.WriteLine("Up");
            Console.WriteLine("Down");
            Console.WriteLine("Right");
            Console.WriteLine("Left");

            string direction = Console.ReadLine().ToLower();

            switch (direction)
            {
                case "up":
                    y++;
                    break;
                case "down":
                    y--;
                    break;
                case "right":
                    x++;
                    break;
                case "left":
                    x--;
                    break;
                default:
                    Console.WriteLine("Invalid direction");
                    break;
            }

            Console.WriteLine("Current position");
            Console.WriteLine("X:" + x + ", Y:" + y);
        }
    }
}
