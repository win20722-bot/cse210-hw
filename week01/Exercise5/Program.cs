using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        String userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        String userNum = Console.ReadLine();
        int userNumconvert = int.Parse(userNum);
        return userNumconvert;
    }

    static int SquareNumber(int squareNum)
    {
        int squareAns = squareNum * squareNum;
        return squareAns;
    }

    static void DisplayResult(String userName, int squareNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNum}");
    }

}