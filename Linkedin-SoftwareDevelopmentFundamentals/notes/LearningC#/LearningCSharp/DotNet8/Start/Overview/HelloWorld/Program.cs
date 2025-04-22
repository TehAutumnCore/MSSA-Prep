// See https://aka.ms/new-console-template for more information
// For .NET 5 and earlier, the console app template generates the following code: 
// dotnet new console

// using System;

// namespace MyApp
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

using System;

namespace HelloWorld // Namespace declaration
{
    class Program // Class declaration
    {
        static void Main(string[] args) // Main method declaration, entry point for the program. The array of strings are whatever the command line arguements that the app was started with.
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("What is your name?");
            string str = Console.ReadLine();
            Console.WriteLine("Why, hello there " + str);
        }
        
    }
    
}
// Console.WriteLine("Hello, World!");