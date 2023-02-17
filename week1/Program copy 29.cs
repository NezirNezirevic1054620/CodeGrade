using System;

namespace GameBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            while (size < 2)
            {
                Console.WriteLine("Enter the size of the board (at least 2):");
                size = Convert.ToInt32(Console.ReadLine());
            }

            char start = 'W';
            if (size % 2 != 0)
                start = 'B';

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.Write(start);
                    else
                        Console.Write(start == 'W' ? 'B' : 'W');
                }
                Console.WriteLine();
            }
        }
    }
}
