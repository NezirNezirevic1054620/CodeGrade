using System;

namespace LowKeyLesson
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Answer the following MCQs:");
            Console.WriteLine("Which of the following is NOT a valid type in C#?");
            Console.WriteLine("A: bool");
            Console.WriteLine("B: int");
            Console.WriteLine("C: var");
            Console.WriteLine("D: string");

            string answer = Console.ReadLine().ToUpper();
            int correct = 0;
            {
                {
                    if (answer == "C") {
                        correct++;
                    }
                        
                    else
                    {
                        Console.WriteLine("You are an idiot");

                    }
                    Console.WriteLine("What happens if you execute the following line C#?");
                    Console.WriteLine("int x = 1.23;");
                    Console.WriteLine("A: x will be 1.23");
                    Console.WriteLine("B: x will be 1");
                    Console.WriteLine("C: x will be 1.0");
                    Console.WriteLine("D: you will get a compiler error");
                    answer = Console.ReadLine().ToUpper();
                    {
                        if (answer == "D")
                            correct++;
                        else
                        {
                            Console.WriteLine("You shouldn't tell anyone about this");
                        }
                        Console.WriteLine("Consider the following line:");
                        Console.WriteLine("double d = 1.23;");
                        Console.WriteLine("What are TWO ways to convert variable d to an int?");
                        Console.WriteLine("A: int i = (int)d;");
                        Console.WriteLine("B: int i = int(d)");
                        Console.WriteLine("C: int i = 0 + d");
                        Console.WriteLine("D: int i = Convert.ToInt32(d)");
                        Console.WriteLine("Your first answer:");
                        answer = Console.ReadLine().ToUpper();
                        Console.WriteLine("Your second answer:");
                        string answer_2 = Console.ReadLine().ToUpper();
                        
                        {
                            if (answer == "A" && answer_2 == "D" || answer == "D" && answer_2 == "A")
                                correct++;
                            else
                            {
                                Console.WriteLine("ok");

                            }
                        }
                        Console.WriteLine("Your score: " + correct + " out of 3.");

                    }
                    Console.WriteLine("Your score: " + correct + " out of 3. Well done!");
                }
            }
        }
    }
}