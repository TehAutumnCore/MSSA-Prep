using System;

namespace Algorithms {
    class Program {

        static Boolean LinearSearch(int[] input, int target) {
            foreach(int current in input) {
                if (target == current) {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args) {
            int[] arr = {1, 2, 3, 4, 5, 6 };
            // Console.WriteLine(LinearSearch(arr, 4));
            // Console.WriteLine(LinearSearch(arr, 8));

            int item = Array.Find(arr, element=> element == 3); //uses a lambda where it looks for an element that meets the condition of element == 3
            Console.WriteLine(3);
            int[] items = Array.FindAll(arr, element => element >= 5); //uses a lambda where it looks for all the elements that meet the condition of element >= 5
            Array.ForEach(items,Console.WriteLine); // Applies Console.WriteLine to items, so it prints every element that is >= 5
        }
    }
}