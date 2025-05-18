using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {

        static void displayFrequencyOfEachElement(int[] arr)
        {
            Dictionary<int, int> freqDictionary = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (freqDictionary.ContainsKey(arr[i]))
                {
                    freqDictionary[arr[i]]++;
                }
                else
                {
                    freqDictionary[arr[i]] = 1;
                }
            }

            foreach (KeyValuePair<int, int> x in freqDictionary)
            {
                Console.WriteLine("Key: " + x.Key + " Count: " + x.Value);
            }
        }

        static void Main(string[] args)
        {
            displayFrequencyOfEachElement(new int[]
            { 3, 0, 2, 4, 7, 3, 4, 5, 7, 6, 7 });
        }
    }
}