using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Vairables
            int gameState = 0;
            string gameInput = "";
            //Menu Loop
            while(gameState == 0)
            {
                //Title
                Console.WriteLine("////FUN GAME TITLE\\\\");
                Console.WriteLine();
                Console.WriteLine("New Game- n");
                Console.WriteLine("Load Game- l");
                Console.WriteLine("Exit- e");

                gameInput = Console.ReadLine();
                if (gameInput == "n")
                if (gameInput == "l")
                if (gameInput == "e")
            }
            //Main Game Loop
            while(gameState == 1)
            {

            }
        }
    }
}
