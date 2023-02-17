using System;

namespace List
{
    class Program
    {
        static void Main()
        {
            var student_grades = new List<double>()
            {
                7, 
                5.5, 
                3.2, 
                10, 
                4.5
            };

            int total_grades = student_grades.Count;
            int count = 0;

            for(int i = 0; i < student_grades.Count; i++)
            {
                if (student_grades[i] >= 5.5)
                {
                    count++;
                }
            }

            Console.WriteLine($"{count} out of {total_grades} students passed");



        }
    }
}
