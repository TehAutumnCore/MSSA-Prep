using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {
        static void printNextGreaterElement(int[] arr) //defines a static method that takes an int arr and prints greater element for each element
        {
            if (arr.Length == 0) //if the arr is empty,     print an empty line and return nothing
            {
                Console.WriteLine();
                return;
            }

            Stack<int> stack = new(); //create a new empty stack
            stack.Push(arr[0]); //push the first element of the array onto the stack to start comparisons

            for (int i = 1; i < arr.Length; i++)
            {
                int next = arr[i];//loopsarray from the second element, next holds the current element for reference which might be the greater element for some elements in the stack
                if (stack.Count > 0) //check if stack is not empty
                {
                    int popped = stack.Pop(); //pop the top element from the stack to compare with next

                    while (popped < next) //while the popped element is less tha next, meaning next is the greater element for popped
                    {
                        Console.WriteLine(popped + "-->" + next); //print the pair showing popped maps to next
                        if (stack.Count == 0) { //if stack is empty after popping break out of while loop
                            break;
                        }
                        popped = stack.Pop(); //if stack not empty, pop the next element to compare with next
                    }

                    if (popped > next) { //after the while loop, if the last popped element is greater than next, it means it still needs a next greater element
                        stack.Push(popped); //push the last popped element onto the stack for future processing
                    }
                }
                stack.Push(next); //push the current element next onto the stack because it might be the greater element for some upcoming elements
            }

            while (stack.Count > 0) { //after processessing all elements in the stack, any elements left in the stack do not have a next greater element
                Console.WriteLine(stack.Pop() + "-->" + -1); //print the rest of the unpaired numbers in stack with -1
            }
        }

        static void Main(string[] args) {
            int[] arr = new int[] {15, 8, 4, 10};
            int[] arr2 = new int[] {2};
            int[] arr3 = new int[] {2, 3};
            int[] arr4 = new int[] {};

            printNextGreaterElement(arr);
            printNextGreaterElement(arr2);
            printNextGreaterElement(arr3);
            printNextGreaterElement(arr4);
        }
    }
}