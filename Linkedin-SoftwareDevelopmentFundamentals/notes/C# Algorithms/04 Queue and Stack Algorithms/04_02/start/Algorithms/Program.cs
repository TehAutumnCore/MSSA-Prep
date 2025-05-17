using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {
        static void Main(string[] args)
        {
            // Queue<int> queue = new Queue<int>();
            Queue<int> queue = new();

            //add 4 items to the queue.
            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(20);
            queue.Enqueue(23);

            //removed 2 items from the queue
            // peeked at one item in the queue
            int removedItem = queue.Dequeue(); //removes first item in queue
            Console.WriteLine(removedItem);// assigns the removed item to a variable
            Console.WriteLine(queue.Dequeue()); //
            Console.WriteLine(queue.Peek()); //will not remove the first item in queue, but allows you to see what is up next.

            int current;
            while (queue.TryDequeue(out current))
            { //boolean method and will let you know whether or not it can dequeue an item
                Console.WriteLine(current);
            }
        }
    }
}