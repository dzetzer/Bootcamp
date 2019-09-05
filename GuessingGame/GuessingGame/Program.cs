using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGuessed;
            bool gameWon = false;

            Console.WriteLine("Enter a number between 1 and 10");
            numGuessed = Convert.ToInt32(Console.ReadLine());

            if (numGuessed == 7) Console.WriteLine("You Won!");
            else Console.WriteLine("You Lost!");
        }
    }
}
