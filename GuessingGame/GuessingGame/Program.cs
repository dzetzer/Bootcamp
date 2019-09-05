using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessAttempts = 0;
            int numGuessed;
            bool gameWon = false;

            while(guessAttempts < 2)
            {
                Console.WriteLine("Enter a number between 1 and 10");
                numGuessed = Convert.ToInt32(Console.ReadLine());

                if (numGuessed == 7) gameWon = true;
                else if (numGuessed == 0) Console.WriteLine("Remember to enter a number between 1 and 10");
                else Console.WriteLine("You Lost!");

                if(gameWon == true) Console.WriteLine("You Won!");
                else
                {
                    Console.ReadLine();
                    Console.Clear();
                    guessAttempts++;
                }
            }
        }
    }
}
