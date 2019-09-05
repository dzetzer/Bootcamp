using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get Personal Info
            string firstName;
            string lastName;
            string age;
            string birthMonth;
            string favColor;
            string sibNumber;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            Console.WriteLine("What number month were you born?");
            birthMonth = Console.ReadLine();

            Console.WriteLine("What is your favorite color");
            favColor = Console.ReadLine();

            Console.WriteLine("How many siblings do you have?");
            sibNumber = Console.ReadLine();
        }
    }
}
