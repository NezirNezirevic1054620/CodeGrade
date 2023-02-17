using System;

namespace WhileItsFair
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int i = 4;
            while (i >=1)
            {   
                Console.WriteLine("Money left: " + i);
                Console.WriteLine("Look around (1) or go in a ride (2)?");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Yay!");
                }
                else if(choice == 2)
                {
                    i--;
                    Console.WriteLine("Wheee!");
                }
                
                    
            }
            Console.WriteLine("Time to go home");
        }
    }
}
