using System;

namespace TimesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number from 2-9:");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                n = 2;
            }
            else if (n > 9)
            {
                n = 9;
            }

            Console.Write("   |");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0,3}", i);
            }
            Console.WriteLine();

            Console.Write("---|");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("---");
            }
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0,2} |", i);
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0,3}", i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
