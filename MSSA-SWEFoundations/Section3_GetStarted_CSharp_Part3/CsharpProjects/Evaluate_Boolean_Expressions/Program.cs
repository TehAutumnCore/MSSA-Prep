// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// These two lines of code will create the same output

// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// int a = 7;
// int b = 6;
// Console.WriteLine(a != b); // output: True
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 != s2); // output: False

//Code Challenge:
/*
Use Random class to generate a value, consider the range of numbers that is required.
Based on the value generated use the conditional operator to display heads or tails ~there should be a 50% chance that the result is either heads or tails
using System;
// using Random;

namespace flipACoin
{
    class RandomClass
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            // bool answer = random.Next(2) == 0 ? false : true; //random.Next(0,2) short hand
            // Console.WriteLine(answer ? "Heads" : "Tails"); //can print answer and swap answer with string answer = random.Next(2) == 0 ? "Heads" : "Tails";
            // string answer = random.Next(2) == 0 ? "Heads" : "Tails";
            // Console.WriteLine(answer);
            Console.WriteLine(random.Next(2) == 0 ? "Heads" : "Tails");
        }
    }
}
*/


//Exercise Complete a challenge activity using Boolean expressions

namespace PermissionExercise
{
    class AuthorizedMaybe
    {
        public static void Main(string[] args)
        {
            // string permission = "Admin | Manager";
            // string permission = "Admin";
            string permission = "Manager";
            // string permission = "Some Random Guy";
            int level = 55;
            // int level = 54;
            // int level = 20;
            // int level = 19;
            /*
                        if (permission == "Admin" && level > 55)
                        {
                            Console.WriteLine("Welcome, Super Admin user.");
                        }
                        else if (permission == "Admin" && level <= 55)
                        {
                            Console.WriteLine("Welcome, Admin user");
                        }


                        if (permission == "Manager" && level >= 20)
                        {
                            Console.WriteLine("Contact an Admin for access.");
                        }
                        else if (permission == "Manager" && level < 20)
                        {
                            Console.WriteLine("You do not have sufficient privileges.");
                        }
            */
            /*
                        if (permission != "Admin" && permission != "Manager")
                        {
                            Console.WriteLine("You do not have sufficient privileges.");
                        }

                        if (permission == "Admin")
                        {
                            if (level >= 55)
                            {
                                Console.WriteLine("Welcome, Super Admin user.");
                            }
                            else
                            {
                                Console.WriteLine("Welcome, Admin user");
                            }
                        }
                        else if (permission == "Manager")
                        {
                            if (level >= 20)
                            {
                                Console.WriteLine("Contact an Admin for access.");
                            }
                            else
                            {
                                Console.WriteLine("You do not have sufficient privileges.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You do not have sufficient privileges.");
                        }
            */
            switch (permission)
            {
                case "Admin" when level > 55:
                    Console.WriteLine("Welcome, Super Admin user.");
                    break;
                case "Admin":
                    Console.WriteLine("Welcome, Admin user");
                    break;
                case "Manager" when level >= 20:
                    Console.WriteLine("Contact an Admin for access.");
                    break;
                default:
                    Console.WriteLine("You do not have sufficient privileges.");
                    break;
            }
        }
    }
}
