using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 100000;
            double interestRate = 0.05;
            int years = 5;
            double taxesPaid = 0;

            for (int i = 0; i < years; i++)
            {
                balance += balance * interestRate;
                if (balance > 100000)
                {
                    taxesPaid += (balance - 100000) * 0.03;
                    balance -= (balance - 100000) * 0.03;
                }
                else if (balance > 50000)
                {
                    taxesPaid += (balance - 50000) * 0.015;
                    balance -= (balance - 50000) * 0.015;
                }
            }

            Console.WriteLine("Balance after " + years + " years: " + (int)balance);
            Console.WriteLine("Amount of taxes paid: " + (int)taxesPaid);
        }
    }
}
