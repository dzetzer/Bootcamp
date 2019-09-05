using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while(1 == 1)
            {
                int numGuessed;
                bool gameWon = false;

                Console.WriteLine("Enter a number between 1 and 10");
                numGuessed = Convert.ToInt32(Console.ReadLine());

                if (numGuessed == 7) Console.WriteLine("You Won!");
                else if (numGuessed == 0) Console.WriteLine("Remember to enter a number between 1 and 10");
                else Console.WriteLine("You Lost!");
                
                
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
