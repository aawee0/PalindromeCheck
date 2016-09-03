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
        static bool IsPalindrome(string s)
        {
            // checking the string for non-letter characters
            //bool lettersOnly = Regex.IsMatch(s, @"^[a-zA-Z]+$");
            //if (lettersOnly == false) Console.WriteLine("Input should be a word that contains latin letters only, please try again.");
            
            // removing all the whitespaces from the string
            string palin = Regex.Replace(s.ToLower(), @"\s+", "");

            int len = palin.Length;
            bool isPalin = true;
            
            // comparing the letters on both sides from the middle
            for (int i = 0; i < len / 2; i++) if (palin[i] != palin[len - 1 - i]) isPalin = false;

            return isPalin;
        }

        static void Check(string s, bool shouldBePalindrome)
        {
            Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
        }

        static void Main(string[] args)
        {
            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);

            
        }
    }
}
