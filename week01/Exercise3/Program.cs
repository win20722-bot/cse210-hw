using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        String ans = "";
        while (ans != "no")
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);
            
            int guessNum = -1;
            int count = 0;

            while (guessNum != magicNum)
            {
                Console.Write("What is your guess? ");
                String guessuserNum = Console.ReadLine();
                guessNum = int.Parse(guessuserNum);
                count += 1;

                if (guessNum > magicNum)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guessNum < magicNum)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You have guessed {count} times.");
                }
            }
            Console.Write("Do you want to play again? ");
            ans = Console.ReadLine();
        }


    } 
}