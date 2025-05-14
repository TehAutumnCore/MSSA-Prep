using System;

namespace Algorithms
{
    class Program
    {

        static string NormalizeString(string input) {
            // string lowercased = input.ToLower(); // will return a new string that is all lowercase, so we will need to store it into a variable
            // string trimmed = lowercased.Trim(); // Will return the lowercased string with no whitespaces on either side of the string
            // return trimmed.Replace(",",""); //will replace the , character with an empty string to remove it.
            return input.ToLower().Trim().Replace(",",""); //Method chaining to help with readability.
        }


        static void Main(string[] args)
        {
            Console.WriteLine(NormalizeString(" Hello There, BUDDY        "));
        }
    }
}