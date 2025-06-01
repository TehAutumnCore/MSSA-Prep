//Fizzbuzz
// Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
// When the current value is divisible by 3, print the term Fizz next to the number.
// When the current value is divisible by 5, print the term Buzz next to the number.
// When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
/* Using if, else if, else
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 != 0)
    {
        Console.WriteLine($"{i} Fizz");
    }
    else if (i % 5 == 0 && i % 3 != 0)
    {
        Console.WriteLine($"{i} Buzz");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} FizzBuzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
*/
/* Optimal with Bang
for (int i = 1; i <= 100; i++)
{
    string output = "";

    if (i % 3 == 0) output += "Fizz";
    if (i % 5 == 0) output += "Buzz";
    // if (i % 7 == 0) output += "Bang";

    Console.WriteLine(output == "" ? i.ToString() : $"{i} {output}");
}
*/

using System;
using System.Collections.Generic;

namespace DataDriven //using dictionary/IList
{
    
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> rules = new Dictionary<int, string>
            {
                {3, "Fizz" },
                {5, "Buzz" },
                {7, "Bang" }
            };

            //IList<string> result = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                string output = "";

                foreach (var rule in rules)
                {
                    if (i % rule.Key == 0)
                    {
                        output += rule.Value;
                    }
                }
                Console.WriteLine(output == "" ? i.ToString() : $"{i} {output}"); //result.Add(output == "" ? i.ToString() : output);
            }
        }
    }
}