using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {

        static void Main(string[] args)
        {
            Stack<string> stack = new();


            Console.WriteLine("Start Main");
            stack.Push("Main");
            Console.WriteLine("Start ResponseBuilder");
            stack.Push("ResponseBuilder");
            Console.WriteLine("Start CallExternalService");
            stack.Push("CallExternalService");
            Console.WriteLine("END: " + stack.Pop());
            Console.WriteLine("Start ParseExternalData");
            stack.Push("ParseExternalData");
            Console.WriteLine("END: " + stack.Pop());
            Console.WriteLine("END: " + stack.Pop());
            Console.WriteLine("END: " + stack.Pop());

            // stack.Peek(); peeks top of the stack without removing the item.
            // stack.TryPeek();
            string item;
            Console.WriteLine(stack.TryPeek(out item));
        }
    }
}