using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int attack = 50;
            double critChance = 0.33;
            int bossHP = 1000;

            Random rand = new Random();

            while (bossHP > 0)
            {
                int damage = attack;
                if (rand.NextDouble() <= critChance)
                {
                    damage *= 2;
                    Console.WriteLine("Critical hit!");
                }

                bossHP -= damage;
                Console.WriteLine("Boss HP: " + bossHP);
                Console.WriteLine("Damage: " + damage);
                Console.WriteLine();
            }

            Console.WriteLine("Boss defeated!");
        }
    }
}
