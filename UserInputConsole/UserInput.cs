using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputPractise
{
    #region Answers exercises 1 and 2
    static class UserInput
    {
        #region User interaction
        public static bool TryReadString(string question, out string answer)
        {
            answer = null;

            Console.WriteLine($"{question} (Empty to quit)?");
            string sInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(sInput) && !string.IsNullOrWhiteSpace(sInput))
            {
                answer = sInput;
                return true;
            }

            return false;
        }
        public static bool TryReadInt32(string question, int minInt, int maxInt, out int answer)
        {
            answer = 0;
            string sInput;
            do
            {
                Console.WriteLine($"{question} ({minInt}-{maxInt} or Q to quit)?");
                sInput = Console.ReadLine();
                if (int.TryParse(sInput, out answer) && answer >= minInt && answer <= maxInt)
                {
                    return true;
                }
                else if (sInput != "Q" && sInput != "q")
                {
                    Console.WriteLine("Wrong input, please try again.");
                }
            }
            while ((sInput != "Q" && sInput != "q"));
            return false;
        }
        public static bool TryReadDateTime(string question, out DateTime answer)
        {
            answer = default;
            string sInput;
            do
            {
                Console.WriteLine($"{question} (Empty or Q to quit)?");
                sInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(sInput) && !string.IsNullOrWhiteSpace(sInput) &&
                    DateTime.TryParse(sInput, out answer))
                {
                    return true;
                }
                else if (sInput != "Q" && sInput != "q")
                {
                    Console.WriteLine("Wrong input, please try again.");
                }
            }
            while ((sInput != "Q" && sInput != "q"));
            return false;
        }
        #endregion
    }
    #endregion
}
