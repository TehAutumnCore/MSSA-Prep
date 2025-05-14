using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static Boolean isUpperCase(string s) { 
            return s.All(char.IsUpper); //All will return a boolean based on whether all the characters in a string meet a condition.
        }

        static Boolean isLowerCase(string s) {
            return s.All(char.IsLower);
        }

        static Boolean isDigits(string s) {
            return s.All(char.IsDigit);
        }

        static Boolean isPasswordComplex(string s) {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }

        /*
        if (s.All(char.isUpper()){
            return true;
        } else {
            return false;
        }
        */

        static void Main(string[] args)
        {
            // Console.WriteLine(isUpperCase("hello")); //False
            // Console.WriteLine(isUpperCase("HELLO")); //True

            // Console.WriteLine(isLowerCase("hello")); //True
            // Console.WriteLine(isLowerCase("HELLO")); //False

            // Console.WriteLine(isDigits("hello")); //False
            // Console.WriteLine(isDigits("43110")); //True

            Console.WriteLine(isPasswordComplex("Hell0"));
            Console.WriteLine(isPasswordComplex("Hello"));
            Console.WriteLine(isPasswordComplex("HellO"));
            Console.WriteLine(isPasswordComplex("HeLlo"));
            Console.WriteLine(isPasswordComplex("hell0"));
            Console.WriteLine(isPasswordComplex(" "));
        }

    }
}