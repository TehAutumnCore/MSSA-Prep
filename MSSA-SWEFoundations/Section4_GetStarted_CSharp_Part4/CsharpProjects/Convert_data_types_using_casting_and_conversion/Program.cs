/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
*/
/*
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);
*/

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

//narrow conversion because we're losing precision going from decimal to float since float is more precise.
// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float: {myFloat}");


//Int to string
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString(); //converts 5 and 7 into a string and puts concatenates them: 57 instead of 12
// Console.WriteLine(message);

//String to Int
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second); //converts 5 and 7 from string to int so they can add together
// Console.WriteLine(sum);

// int value = (int)1.5m;//casting truncates - value after the decimal point is ignored
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); //Converting rounds up, 1.499m would round down to 1
// Console.WriteLine(value2);

// int value3 = Convert.ToInt32(1.499m); //Converting rounds down, 1.499m would round down to 1
// Console.WriteLine(value3);

// string name = "Bob";
// Console.WriteLine(int.Parse(name)); // Unhandled exception. System.FormatException: The input string 'Bob' was not in a correct format.

/*
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
    if (result > 0) {
        Console.WriteLine($"Measurement (w/ offset): {50+result}")
    }
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
*/


// string value = "102";
// string value = "bad";
// Console.WriteLine(int.TryParse(value, out int result) ? $"Measurement: {result}" : "Unable to report the measurement");

// if (result > 0) Console.WriteLine($"Measurement (w/ offset): {50 + result}");

//Rule 1: If the value is alphabetical, concatenate it to form a message.
// Rule 2: If the value is numeric, add it to the total.
// Rule 3: The result should match the following output:
/*
using System;
using System.Text;

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0;
// var message = "";
var messageBuilder = new StringBuilder();
foreach (var value in values)
{
    if (decimal.TryParse(value, out var validValue)) //handles
    {
        total += validValue;
    }
    else
    {
        // message += value;
        messageBuilder.Append(value);
    }
}
Console.WriteLine($"Message: {messageBuilder.ToString()}");
Console.WriteLine($"Total: {total}");
*/

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Solve for result1: Divide value1 by value2, display the result as an int
// Solve for result2: Divide value2 by value3, display the result as a decimal
// Solve for result3: Divide value3 by value1, display the result as a float

int result1 = Convert.ToInt32(value1/value2); //display as an int
decimal result2 = value2/(decimal)value3; //display as a decimal
float result3 = value3/value1; //display as a float

//Your code here to set result1
//Hint: You need to round the result to nearest integer(don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
//Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
//Your code here to set result3
Console.WriteLine($"Divide value3 by value4, display the result as a float: {result3}");