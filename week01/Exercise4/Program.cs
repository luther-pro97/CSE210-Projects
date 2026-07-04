using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine()!);
            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }


        int sum = 0;
        int max = numbers[0];
        foreach (int n in numbers)
        {
            sum += n;
            if (n > max)

            {
                max = n;
            }
        }
        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}