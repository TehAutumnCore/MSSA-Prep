using System;

namespace Algorithms {

    class Program {
        static int findMaximum(int a, int b, int c) {
            if (a > b) {
                if (a > c || a == c) {
                    return a;
                }
            }

            if (b > c) {
                if (b > a || a == b) {
                    return b;
                }
            }

            return c;
        }

        static int findMaximum2(int a, int b, int c) {
            int max = a;

            if (b>max) {
                max = b;
            }

            if (c > max) {
                max = c;
            }
            return max;

        }
        // ---------- using the Math.Max method from the Math class by comparing the largest value of a and b, and then comparing the highest value to the value of c.
        static int findMaximum3(int a, int b, int c) {
            return Math.Max(Math.Max(a, b),c);
        }

        static void Main(string[] args) {
            Console.WriteLine(findMaximum3(1, 2, 3));
            Console.WriteLine(findMaximum3(8, 8, 1));
            Console.WriteLine(findMaximum3(3, 2, 3));
            Console.WriteLine(findMaximum3(1, 1, 9));
            Console.WriteLine(findMaximum3(1, 9, 9));
        }
    }
}