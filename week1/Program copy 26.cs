using System;

namespace PaymentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the amount to pay?");
            int amount = int.Parse(Console.ReadLine());
            int paid = 0;

            while (paid < amount)
            {
                Console.WriteLine($"{amount - paid} left to pay");
                Console.WriteLine("Pay how much?");
                Console.WriteLine("1: 5");
                Console.WriteLine("2: 10");
                Console.WriteLine("3: 20");
                Console.WriteLine("4: 50");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        paid += 5;
                        break;
                    case 2:
                        paid += 10;
                        break;
                    case 3:
                        paid += 20;
                        break;
                    case 4:
                        paid += 50;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }

            if (paid > amount)
            {
                Console.WriteLine($"You paid {paid - amount} too much. Give a tip? y/n");
                string tip = Console.ReadLine();

                while (tip.ToLower() != "y" && tip.ToLower() != "n")
                {
                    Console.WriteLine("Invalid option. Try again.");
                    Console.WriteLine($"You paid {paid - amount} too much. Give a tip? y/n");
                    tip = Console.ReadLine();
                }

                if (tip.ToLower() == "y")
                {
                    Console.WriteLine($"You have paid {paid}");
                }
                else
                {
                    Console.WriteLine($"You have paid {amount}");
                }
            }
            else
            {
                Console.WriteLine($"You have paid {paid}");
            }
        }
    }
}
