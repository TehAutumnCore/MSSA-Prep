using System;

namespace Algorithms
{
    class Program
    {

        static void ParseContents(string s) {
            Console.WriteLine("Option 1");

            foreach (char c in s) {
                Console.WriteLine(c);
            }

            Console.WriteLine("Option 2");
            for (int i = 0; i < s.Length; i++) {
                char c = s[i];
                Console.WriteLine(c);
            }
        }


        static Boolean isAtEvenIndex(string s, char item) {
            if (String.IsNullOrEmpty(s)) {
                return false;
            }

            for (int i = 0; i < s.Length; i=i+2) { // can also write i = i + 2 as i+=2
                if(s[i] == item) {
                    return true;
                } 
            }
            return false;
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("HeLLo World".ToLower().Contains("ll"));
            // ParseContents("Hello World");
            String input = "HeLLo";
            Console.WriteLine(isAtEvenIndex(input, 'l'));
            Console.WriteLine(isAtEvenIndex(input, 'T'));
            Console.WriteLine(isAtEvenIndex(input, 'H'));
            Console.WriteLine(isAtEvenIndex("", 'H'));
            Console.WriteLine(isAtEvenIndex(null, 'H'));
        }
    }
}