using System;

namespace Algorithms {
    class Program {
        static int[] Reverse(int[] input) {
            int[] reversed = new int[input.Length];

            for (int i = 0; i < reversed.Length; i++) {
                reversed[i] = input[input.Length - i - 1];
            }

            return reversed;
        }

        static void ReverseInPlace(int[] input) {

            for (int i = 0; i < input.Length / 2; i++) {
                // Swap index(i) with index(input.Length - i - 1)
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
        }

         static void ReverseInPlace2(int[] input) {
            int left = 0;
            int right = input.Length-1;

            while (left < right) {
                int temp = input[left];
                input[left] = input[right];
                input[right] = temp;

                left++;
                right--;
            }
        }

        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            // Array.ForEach(Reverse(arr), Console.WriteLine);
            // Array.ForEach(ReverseInPlace2(arr),Console.WriteLine);
            ReverseInPlace(arr);
            ReverseInPlace(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}