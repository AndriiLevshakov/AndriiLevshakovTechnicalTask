using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Task: Enter a number:");
        int number = int.Parse(Console.ReadLine());

        if (number > 7)
        {
            Console.WriteLine("Hello");
        }

        Console.WriteLine("Task: Enter a name");
        string name = Console.ReadLine();

        if (name == "John")
        {
            Console.WriteLine("Hello, John");
        }
        else
        {
            Console.WriteLine("There is no such name");
        }

        Console.WriteLine("Task: Enter an array of numbers (comma-separated):");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

        Console.WriteLine("Elements that are multiples of 3:");
        foreach (int num in numbers)
        {
            if (num % 3 == 0)
            {
                Console.WriteLine(num + " ");
            }
        }

    }
}