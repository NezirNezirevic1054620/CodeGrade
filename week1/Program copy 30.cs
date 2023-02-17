List<double> grades = new List<double> { 6.5, 9.5, 4, 5, 4.5, 10, 7.1 };

for (int i = 0; i < grades.Count; i++)
{
    if (grades[i] < 5.5)
    {
        Console.WriteLine("Retake this course? y/n");
        string answer = Console.ReadLine();
        while (answer.ToLower() != "y" && answer.ToLower() != "n")
        {
            Console.WriteLine("Retake this course? y/n");
            answer = Console.ReadLine();
        }

        if (answer.ToLower() == "y")
        {
            grades[i]++;
        }
    }

    Console.WriteLine("Grade: " + grades[i]);
}

Console.WriteLine("Final grades:");
foreach (double grade in grades)
{
    Console.WriteLine(grade);
}
