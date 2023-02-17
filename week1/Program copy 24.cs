using System;

namespace List
{
    class Program
    {
        static void Main()
        {
            var task_list = new List<string>()
            {
                
            };

            int total_tasks_1 = task_list.Count();
            Console.WriteLine($"Amount of tasks: {total_tasks_1}");

            foreach (string task in task_list)
            {
                Console.WriteLine(task);
            }

            task_list.Add("Mow lawn");
            task_list.Add("Pay taxes");

            int total_tasks_2 = task_list.Count();
            Console.WriteLine($"Amount of tasks: {total_tasks_2}");

            foreach (string task in task_list)
            {
                Console.WriteLine(task);
            }

            task_list.Remove("Mow lawn");
            task_list.Add("Shopping");

            int total_tasks_3 = task_list.Count();
            Console.WriteLine($"Amount of tasks: {total_tasks_3}");
            
            foreach (string task in task_list)
            {
                Console.WriteLine(task);
            }
        }
    }
}