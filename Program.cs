using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string palin = null; // palindrome string
            bool noArgs = false; // a variable indicating lack of arguments

            // trying to get a string out of command line arguments
            try
            {
                palin = args[0];
            }
            catch (Exception e)
            {
                noArgs = true;
                Console.WriteLine("Incorrect argument. Usage: PalindromeCheck [word]");
            }

            // if an argument is in place, continue
            if (noArgs == false)
            {
                // checking the string for non-letter characters
                bool lettersOnly = Regex.IsMatch(palin, @"^[a-zA-Z]+$");
                if (lettersOnly == false) Console.WriteLine("Input should be a word that contains latin letters only, please try again.");
                else
                {
                    // if the input is correct, compare the letters
                    int len = palin.Length;

                    bool isPalin = true;
                    for (int i = 0; i < len / 2; i++) if (palin[i] != palin[len - 1 - i]) isPalin = false;

                    if (isPalin) Console.Write("\"" + palin + "\"" + " is a palindrome.");
                    else Console.Write("\"" + palin + "\"" + " is NOT a palindrome.");
                }
            }
        }
    }
}
