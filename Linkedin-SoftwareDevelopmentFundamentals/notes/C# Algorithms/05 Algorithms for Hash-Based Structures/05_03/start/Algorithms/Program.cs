using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {

        static List<int> findMissingElements(int[] first, int[] second)
        {
            List<int> missingElements = new();
            HashSet<int> secondArrayItems = new();

            foreach (int item in second)
            {
                secondArrayItems.Add(item);
            }

            foreach (int item in first)
            {
                if (!secondArrayItems.Contains(item))
                {
                    missingElements.Add(item);
                }
            }

            return missingElements;
        }
        static void Main(string[] args)
        {
            findMissingElements(new int[] { 1, 2, 3, 4 },
                new int[] { 2, 4 }).ForEach(Console.WriteLine);
            Console.WriteLine();
            findMissingElements(new int[] { 3, 2, 8, 4, 5 },
                new int[] { 5, 7, 3, 0, 2 }).ForEach(Console.WriteLine);
        }
    }
}

//time complexity: O(n+m) because it takes O(m) time to iterate through the second array and add each element to the HashSet and hashset lookup is O(1) so the loop is O(n)
//space complexity: O(n+m) because we're loop through arrays once and adding each element, although lookup time is O(1)