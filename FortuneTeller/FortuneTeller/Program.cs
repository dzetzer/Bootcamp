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

            Console.Clear();

            //Retirement
            string retirement;
            if (Convert.ToInt32(age) % 2 == 0) retirement = "12 years";
            else retirement = "14 years";
            //Vacation Home
            string vacaHome = null;
            if (Convert.ToInt32(sibNumber) == 0) vacaHome = "Boca Raton, FL";
            if (Convert.ToInt32(sibNumber) == 1) vacaHome = "Nassau, Bahamas";
            if (Convert.ToInt32(sibNumber) == 2) vacaHome = "Ponta Negro, Brazil";
            if (Convert.ToInt32(sibNumber) == 3) vacaHome = "Portland, Oregon";
            if (Convert.ToInt32(sibNumber) > 3) vacaHome = "Baton Rouge, LA";
            if (Convert.ToInt32(sibNumber) < 0) vacaHome = "Chernobyl, Ukraine";
            //Transportation
            string Transport = null;
            if (favColor.ToLower() == "red") Transport = "Maserati";
            if (favColor.ToLower() == "orange") Transport = "stallion";
            if (favColor.ToLower() == "yellow") Transport = "chariot";
            if (favColor.ToLower() == "green") Transport = "taxi";
            if (favColor.ToLower() == "blue") Transport = "rickshaw";
            if (favColor.ToLower() == "indigo") Transport = "motor scooter";
            if (favColor.ToLower() == "violet") Transport = "flying saucer";
            //Bank Balance
            int birthMonthInt = Convert.ToInt32(birthMonth);
            string bankBalance = null;
            if (birthMonthInt >= 1 && birthMonthInt <= 4) bankBalance = "$256,000.76";
            if (birthMonthInt >= 5 && birthMonthInt <= 8) bankBalance = "$3,687,105.42";
            if (birthMonthInt >= 5 && birthMonthInt <= 8) bankBalance = "$86.23";
            if (birthMonthInt > 12 || birthMonthInt < 1) bankBalance = "$0.00";

            Console.WriteLine(firstName + " " + lastName + "will retire in " + retirement + " with " + bankBalance + " in the bank, a vacation home in " + vacaHome + ", and travel by" + Transport + ".");
            Console.ReadLine();

        }
    }
}
