using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {
        static void printBinary(int n)
        {
            if (n <= 0)
            {
                return;
            }

            Queue<int> queue = new();
            queue.Enqueue(1);
            for (int i = 0; i < n; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(current * 10);
                queue.Enqueue(current * 10 + 1);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            printBinary(5); //prints first 5 binary numbers
            printBinary(-2); //invalid
            printBinary(0); //invalid
            printBinary(2); //print first 2 binary numbers
            printBinary(8); //print first 8 binary numbers
        }
    }
}