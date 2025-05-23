﻿using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // TODO: Output information using formatting
            Console.WriteLine("This car is a {0} {1} {2}. with {3} miles and costs ${4}",
            year, make, model, miles, price);
            // This car is a 2020 Mercedes-Benz G Class. with 8450.27 miles and costs $60275.0

            // TODO: Using string interpolation
            Console.WriteLine($"This car is a {year} {make} {model}, with {miles} miles and costs {price:C2}");
            // This car is a 2020 Mercedes-Benz G Class, with 8450.27 miles and costs $60,275.00

            // TODO: With inline expressions
            Console.WriteLine($"This car is a {year} {make} {model}, with {{{miles * 1.6:F2}}} km and costs {price:C2}");
            // This car is a 2020 Mercedes-Benz G Class, with {13520.43} km and costs $60,275.00
        }
    }
}
