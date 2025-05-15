using System;

namespace Algorithms {
    class Program {

        static Boolean BinarySearch(int[] inputArray, int target) {
            int min = 0; //index starts at beginning
            int max = inputArray.Length-1; //index starts at the

            while (min <= max) { // while the min <= max
                int mid = (min + max) /2; //defining mid point by using the average of the min and max

                if (target == inputArray[mid]) { //if the target is at the midpoint, return true and end the code
                    return true;
                } else if (target < inputArray[mid]) { //if the midpoint is larger than the target, then reassign the max to the middle-1 to close in on the inner array
                    max = mid-1;
                } else { //then the target > inputArray[mid]
                    min = mid+1;
                }
            }
            return false;
        }

        static void Main(string[] args) {
            int[] arr = {1, 2, 3, 4, 5, 6 };
            Console.WriteLine(BinarySearch(arr,5));
            // Array.BinarySearch(arr,1);
        }
    }
}