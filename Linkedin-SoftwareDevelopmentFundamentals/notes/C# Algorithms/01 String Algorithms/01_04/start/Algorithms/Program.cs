using System;
using System.Text;

namespace Algorithms
{
    class Program
    {

        static string Reverse(string input) {
            if(string.IsNullOrEmpty(input)) { //covers base case of string being null or empty
                return input;
            }

            StringBuilder reversed = new StringBuilder(input.Length); //string builder doesnt build a new string, but dynamically expands memory to accommodate the modified string.Making it more efficient than a regular string
            for(int i = input.Length-1; i >= 0; i--) { // Start from the last index; i >= 0; decrement by 1 on every iteration until we get to the end of the string.
                reversed.Append(input[i]);
            }

            return reversed.ToString(); // converts stringbuilder back to string.
        }

        static string Reverse2(String input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);

        }

        static void Main(string[] args)
        {
            Console.WriteLine(Reverse2("Hello World"));
            Console.WriteLine(Reverse2(""));
            Console.WriteLine(Reverse2("hello"));
            Console.WriteLine(Reverse2("tacos"));
            Console.WriteLine(Reverse2("Hi!"));
            Console.WriteLine(Reverse2(null));
        }
    }
}