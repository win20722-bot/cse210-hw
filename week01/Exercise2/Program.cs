using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        String userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        int lastDigit = grade % 10;
        String lastSign;
        if (lastDigit >= 7)
        {
            lastSign = "+";
        }
        else if (lastDigit < 3)
        {
            lastSign = "-";
        }
        else
        {
            lastSign = "";
        }

        String letter= "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 90 || grade < 60)
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}{lastSign}");
        }
        

        if (grade >= 70)
        {
            Console.WriteLine("You have passed the course!");
        }
        else
        {
            Console.WriteLine("You did not pass. Keep going!");
        }


    }
}