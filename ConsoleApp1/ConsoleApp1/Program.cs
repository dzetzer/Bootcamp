using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int appState = 0;
            string firstName = "";
            string lastName = "";

            //Display
            while (appState != -1)
            {
                //Headsup Display
                Console.WriteLine("First Name: " + firstName + ", Last Name: " + lastName);
                //Get First Name
                switch(appState)
                {
                    case 0:
                        Console.WriteLine("Please enter your first name");
                        firstName = Console.ReadLine();
                        appState = 1;
                        break;
                    case 1:
                        Console.WriteLine("Please enter your last name");
                        lastName = Console.ReadLine();
                        appState = 2;
                        break;
                    case 2:
                        if (firstName.Length > lastName.Length) Console.WriteLine("Your First Name is longer than your Last Name");
                        if (firstName.Length < lastName.Length) Console.WriteLine("Your Last Name is longer than your First Name");
                        if (firstName.Length == lastName.Length) Console.WriteLine("Your First and Last Names are equal in Length");
                        Console.WriteLine("Press Enter to Reset");
                        Console.ReadLine();
                        firstName = "";
                        lastName = "";
                        appState = 0;
                        break;
                }
                Console.Clear();
            }
        }
    }
}
