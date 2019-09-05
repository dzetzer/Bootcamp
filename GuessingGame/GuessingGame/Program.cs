﻿using System;

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

                //Guess Responses
                if (numGuessed == 7) gameWon = true;
                else if (numGuessed == 0) Console.WriteLine("Remember to enter a number between 1 and 10");
                else if (numGuessed == -1) Environment.Exit(1);
                else Console.WriteLine("You Lost!");

                //Win Game
                if (gameWon == true)
                {
                    Console.WriteLine("You Won!");
                    guessAttempts = 2;
                }
                else
                {
                    //Show if Greater or Less
                    if (numGuessed > 7) Console.WriteLine("Your number is greater than the correct number");
                    if (numGuessed < 7) Console.WriteLine("Your number is less than the correct number");
                    //Restart
                    Console.ReadLine();
                    Console.Clear();
                    guessAttempts++;
                }
            }
        }
    }
}
