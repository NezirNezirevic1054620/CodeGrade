using System;


namespace App
{

    class ConditionalOperator
    {

        static void Main(string[] args)
        { 

            Console.Write("What is your age? ");
            int age_1 = int.Parse(Console.ReadLine());

            Console.Write("What is the age of the student next to you?");
            int age_2 = int.Parse(Console.ReadLine());

            if (age_1 == age_2)
            {
                Console.Write("Your ages are equal");
            }
            else if (age_1 > age_2)
            {
                Console.Write("You are older");
            }
            else if (age_1 < age_2)
            {
                Console.Write("You are younger");
            }
        }
    }
}