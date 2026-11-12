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
            String userInput;
            userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        float average = 0;
        float sum = 0;
        foreach (int listNum in numbers)
        {
            sum += listNum;
        }
        average = sum / numbers.Count;

        int largeNum = numbers[0];
        foreach (int ListNum in numbers)
        {
            if (ListNum > largeNum)
            {
                largeNum = ListNum;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largeNum}");

        int positiveSmall = int.MaxValue;

        foreach (int i in numbers)
        {
            if (i > 0 && i < positiveSmall)
            {
            positiveSmall = i;
            }
        }

        if (positiveSmall == int.MaxValue)
        {
            Console.WriteLine("There are no positive numbers.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {positiveSmall}");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}