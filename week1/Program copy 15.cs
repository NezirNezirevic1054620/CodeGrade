using System;

namespace CompassDirection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] directions = { "North", "East", "South", "West" };
            bool[] validDirections = new bool[4];

            Console.WriteLine("For each direction, input Y/N if it is valid.");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(directions[i] + "? Y/N");
                char input = Console.ReadLine().ToUpper()[0];
                if (input == 'Y')
                {
                    validDirections[i] = true;
                }
            }

            Console.WriteLine("From here you can go:");
            if (validDirections[0])
            {
                Console.WriteLine("    N");
                Console.WriteLine("    |");
            }
            Console.Write("W---|");
            if (validDirections[1])
            {
                Console.WriteLine("---E");
            }
            else
            {
                Console.WriteLine();
            }
            if (validDirections[2])
            {
                Console.WriteLine("    |");
                Console.WriteLine("    S");
            }

            Console.WriteLine("\nGive a bearing (a number) for the direction in which you are going.");
            double bearing = Convert.ToDouble(Console.ReadLine());
            while (bearing >= 360)
            {
                bearing -= 360;
            }
            while (bearing < 0)
            {
                bearing += 360;
            }

            string direction = "";
            if (bearing >= 315 || bearing < 45)
            {
                direction = "North";
            }
            else if (bearing >= 45 && bearing < 135)
            {
                direction = "East";
            }
            else if (bearing >= 135 && bearing < 225)
            {
                direction = "South";
            }
            else if (bearing >= 225 && bearing < 315)
            {
                direction = "West";
            }

            if (direction == "")
            {
                Console.WriteLine("Invalid bearing");
            }
            else if (validDirections[Array.IndexOf(directions, direction)])
            {
                Console.WriteLine("You are going " + direction);
            }
            else
            {
                Console.WriteLine("You can't go " + direction);
            }
        }
    }
}
