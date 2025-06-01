/*Example 1
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.WriteLine();
} while (readResult == null);
*/
/*Example 2
string? readResult;
bool validEntry = false;

//Capture user input in a string variable named readResult

validNumber = int.TryParse(readResult, out numericValue);
Console.WriteLine("Enter a string containing at least three characters:");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
    while (validEntry == false);
}
*/

using System;
using System.Collections.Generic;

/*Instructions
    Your solution must include either a do-while or while iteration.

    Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

    Inside the iteration block:

    Your solution must use a Console.ReadLine() statement to obtain input from the user.
    Your solution must ensure that the input is a valid representation of an integer.
    If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
    Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
    Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

Output:
    Enter an integer value between 5 and 10
    two
    Sorry, you entered an invalid number, please try again
    2
    You entered 2. Please enter a number between 5 and 10.
    7
    Your input value (7) has been accepted.
*/
namespace project1
{
    class Solution
    {
        public static void Run()
        {
            Console.WriteLine("Running Project1 ...");

            string? userInput = "";
            bool validNumber;
            int numericValue;
            bool validEntryFlag = false;
            Console.WriteLine("Enter a number between 5 and 10");
            
            while (!validEntryFlag)
            {
                userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out numericValue);

                if (validNumber && numericValue >= 5 && numericValue <= 10)
                {
                    Console.WriteLine($"Your input value ({userInput}) has been accepted.");
                    validEntryFlag = true;
                } else if (!validNumber) {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");

                }
                else
                {
                    Console.WriteLine($"You entered {userInput}. Please enter a number between 5 and 10.");
                }
            }
        }
    }
}

/* Instructions
    Your solution must include either a do-while or while iteration.

    Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

    Inside the iteration block:

    Your solution must use a Console.ReadLine() statement to obtain input from the user.
    Your solution must ensure that the value entered matches one of the three role options.
    Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
    Your solution should use the ToLower() method on the input value to ignore case.
    If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
    Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

Output:
    Enter your role name (Administrator, Manager, or User)
    Admin
    The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
       Administrator
    Your input value (Administrator) has been accepted.
*/
namespace project2
{
    class Solution
    {
        public static string normalizeString(string? str) {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            return (char.ToUpper(str[0]) + str.Substring(1).ToLower()).Trim();
        }

        public static void Run()
        {
            Console.WriteLine("Running Project2 ...");

            string? userInput = "";
            string validName;
            bool validEntryFlag = false;
            Console.WriteLine("Enter your role name (Administrator, Manager, or User)");


            while (!validEntryFlag) {
                userInput = Console.ReadLine();
                validName = normalizeString(userInput);

                if (validName == "Administrator" || validName == "Manager" || validName == "User")
                {
                    Console.WriteLine($"Your input value ({validName}) has been accepted.");
                    validEntryFlag = true;
                }
                else
                {
                    Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
                }
            }
        }
    }
}

/*Instructions
Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.

In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.

Your solution must include an inner do-while or while loop that can be used to process the myString variable.

In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.

In the inner loop, your solution must not display the period character.

In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.

Output:
    I like pizza
    I like roast chicken
    I like salad
    I like all three of the menu choices
*/

namespace project3
{
    class Solution
    {
        public static void Run()
        {
            Console.WriteLine("Running Project 3...");

            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

            int periodLocation; //used to hold the location of the period char within the string

            foreach (string myString in myStrings)
            {
                // Console.WriteLine(myString); //for console visual

                string tempString = myString;
                periodLocation = tempString.IndexOf('.');
                while (periodLocation != -1)
                {
                    Console.WriteLine(tempString.Substring(0, periodLocation).TrimStart());
                    tempString = tempString.Remove(0, periodLocation + 1);
                    periodLocation = tempString.IndexOf('.');
                }
                if (!string.IsNullOrWhiteSpace(tempString)) //prints leftover if no period remains
                {
                    Console.WriteLine(tempString.TrimStart());
                }
            }

        }
    }
}


class Program
{
    public static void Main(string[] args)
    {
        // project1.Solution.Run();
        // project2.Solution.Run();
        project3.Solution.Run();
    }
}