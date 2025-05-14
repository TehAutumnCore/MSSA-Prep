using System;

namespace Algorithms
{
    class Program
    {

        public static string ReverseEachWord(string sentence)
    {
        if (String.IsNullOrEmpty(sentence)) {
            return sentence;
        }
        string[] words = sentence.Split(' '); // [sally,is,a,great,worker]
        
        for (int i = 0; i < words.Length; i++) {
            words[i] = Reverse(words[i]);
        }

        return string.Join(" ",words); //combine back into string
        }

        static String Reverse(String input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        static void Main(string[] args) {
            Console.WriteLine(ReverseEachWord("Taylor is a great worker"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("racer racecar madam"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
            Console.WriteLine(ReverseEachWord(" "));
        }
    }
}



