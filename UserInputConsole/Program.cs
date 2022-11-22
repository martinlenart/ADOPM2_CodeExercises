using System;

namespace UserInputPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            string YourName = null, FathersName = null, MothersName = null;
            int NrSiblings = 0, NrCousins = 0;

            Console.WriteLine($"Try pattern for user input from console!\n");
            bool Continue =  UserInput.TryReadString("What is your name", out YourName) &&
                        UserInput.TryReadString("What is your father's name", out FathersName) &&
                        UserInput.TryReadString("What is your mother's name", out MothersName);
                        // Terminate if Quit
            if (!Continue) return;

            Console.WriteLine($"\nHi {YourName}. Your father's name is {FathersName} and your mother's name is {MothersName}");

            Continue = UserInput.TryReadInt32("How many brothers and sisters do you have", 0, 20, out NrSiblings) &&
                       UserInput.TryReadInt32("How many cousins do you have", 0, 200, out NrCousins);

            // Terminate if Quit
            if (!Continue) return;

            Console.WriteLine($"\nYou have {NrSiblings} brothers and sisters and {NrCousins} cousins");

            DateTime BirthDay = default;
            Continue = UserInput.TryReadDateTime("What is your birthday", out BirthDay);
            
            // Terminate if Quit
            if (!Continue) return;

            Console.WriteLine($"\nYour birthday is {BirthDay:d}");
        }
    }
}
