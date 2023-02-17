using System;

class Program
{
    public static void Main()
    {
        Fighter you = new Fighter();
        Fighter enemy = new Fighter();
        int turnsTaken = 0;

        //Correct the code below
        while (enemy.Health > 0)
        {
            enemy.Health -= you.Attack();
            turnsTaken++;
        }
        //Correct the code above

        Console.WriteLine($"The enemy's HP was reduced to {enemy.Health}");
        Console.WriteLine($"It took you {turnsTaken} to defeat the enemy");
    }
}
