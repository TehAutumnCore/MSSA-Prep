/*
This code uses a names array and corresponding methods to display greeting messages
*/

/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

/*
string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

string messageText = "";

foreach (string name in names)
{
    if (name == "Sophia")
        messageText = SophiaMessage();
    else if (name == "Andrew")
        messageText = AndrewMessage();
    else if (name == "AllGreetings")
        messageText = SophiaMessage() + "\n\r" + AndrewMessage();

    Console.WriteLine(messageText + "\n\r");
}

bool pauseCode = true;
while (pauseCode == true);

static string SophiaMessage()
{
    return "Hello, my name is Sophia.";
}

static string AndrewMessage()
{
    return "Hi, my name is Andrew. Good to meet you.";
}
*/
/*
int productCount = 2000;
string[,] products = new string[productCount, 2];

LoadProducts(products, productCount);

for (int i = 0; i < productCount; i++)
{
    string result;
    result = Process1(products,i);

    if (result != "obsolete")
    {
        result = Process2(products, i);
    }
}

bool pauseCode = true;
while (pauseCode == true);

static void LoadProducts(string[,] products, int productCount)
{
    Random rand = new Random();

    for (int i = 0; i < productCount; i++)
    {
        int num1 = rand.Next(1, 10000) + 10000;
        int num2 = rand.Next(1, 101);

        string prodID = num1.ToString();

        if (num2 < 91)
        {
            products[i, 1] = "existing";
        }
        else if (num2 == 91)
        {
            products[i, 1] = "new";
            prodID = prodID + "-n";
        }
        else
        {
            products[i, 1] = "obsolete";
            prodID = prodID + "-0";
        }

        products[i, 0] = prodID;
    }
}

static string Process1(string[,] products, int item)
{
    Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

    return products[item, 1];
}

static string Process2(string[,] products, int item)
{
    Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
    if (products[item, 1] == "new")
        Process3(products, item);

    return "continue";
}

static void Process3(string[,] products, int item)
{
    Console.WriteLine($"Process3 message - processing product information for 'new' product");
}
*/
/*
string? readResult;
int startIndex = 0;
bool goodEntry = false;

int[] numbers = { 1, 2, 3, 4, 5 };

// Display the array to the console.
Console.Clear();
Console.Write("\n\rThe 'numbers' array contains: { ");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}

// To calculate a sum of array elements, 
//  prompt the user for the starting element number.
Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
while (goodEntry == false)
{
    readResult = Console.ReadLine();
    goodEntry = int.TryParse(readResult, out startIndex);

    if (startIndex > 5)
    {
        goodEntry = false;
        Console.WriteLine("\n\rEnter an integer value between 1 and 5");
    }
}

// Display the sum and then pause.
Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex-1)}");

Console.WriteLine("press Enter to exit");
readResult = Console.ReadLine();

// This method returns the sum of elements n through 5
static int SumValues(int[] numbers, int n)
{
    int sum = 0;
    for (int i = n; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}
*/
/*
bool exit = false;
var rand = new Random();
int num1 = 5;
int num2 = 5;

do
{
    num1 = rand.Next(1, 11);
    num2 = num1 + rand.Next(1, 51);

} while (exit == false);
*/

/*
This code instantiates a value and then calls the ChangeValue method to update the value. The code then prints the updated value to the console.
}
*/

// int x = 5;

// ChangeValue(x);

// Console.WriteLine(x);

// int ChangeValue(int value)
// {
//     value = 10;
//     return value;
// }

/*
try
{
    //Step 1: code execution begins
    try
    {
        //step 2: an exception occurs here
    }
    finally
    {
        //Step 4 : the system executes teh finally code block associated with the try statement where the exception occurred
    }
}
catch //step 3: the system finds a catch clause that can handle the exception
{
    //step 5: The system transfers control to the first line of the catch code block.
}
*/

/*ArrayTypeMismatchException
An exception of type ArrayTypeMismatchException is thrown when an attempt is made to store an element of the wrong type within an array. The following example throws an ArrayTypeMismatchException exception when trying to store a numeric value in a string array.
string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;

Object obj = (Object)13;
objs[2] = obj; // ArrayTypeMismatchException occurs
*/

/* DivideByZeroException
An exception of type DivideByZeroException occurs when trying to divide an integer or Decimal number by zero. The following example throws a DivideByZeroException exception when 
performing integer division 

int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2);
*/

/* FormatException
An exception of type FormatException occurs when the format of an argument is invalid or when a composite format string is not well formed. The following example throws a FormatException wxception when trying to convert a string to an integer.

int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); //FormatException occurs
*/

/*IndexOutOfRangeException
An exception of type IndexOutOfRangeException is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds. The following example throws an IndexOutOfRangeException exception when attempting to assign the last element of the values1 array to the last element of the values2 array.

int[] values1 = {3,6,9,12,15,18,21};
int[] values2 = new int[]6;

values2[values1.Length - 1] = values1[values1.Length-1]; //IndexOutOfRangeException occurs
*/

/* InvalidCastException
An exception of type InvalidCastException is thrown when attempting an invalid casting or explicit conversion. The following example throws an InvalidCastException when attempting to cast an object of type string to an int variable.

object obj = "This is a string";
int num = (int)obj;
*/

/*NullReferenceException
An exception of type NullReferenceException is thrown when attempting to access a member on a type whose value is null. Two examples are thrown. In the first example, a NullReferenceException is thrown when attempting to access an element of a null array. The second example throws a NullReferenceException when attempting to access a method of a null string.

int[]values = null;
for(int i = 0; i <= 9l i++) {
    values[i] = i * 2;
}

string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());
*/

/*Overflow Exception
An exception of type OverflowException occurs when an arithmetic operation attempts to assign a result that's outside the range of the target data type. The following example throws an OverflowException exception when attemptiing to convert a decimal vlaue of 400 to a byte variable.

decimal x = 400;
byte i;

i = (byte)x; //OverflowException
Console.WriteLine(i);
*/
/*
Implement try-catch exception handling

double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;

// Console.WriteLine(float1 / float2);
// Console.WriteLine(number1 / number2);
try
{
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);

}
catch
{
    Console.WriteLine("An exception has been caught.");
}
Console.WriteLine("Exit program");
*/
/*
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has been thrown");
}
Console.WriteLine("Exit Program");

static void Process1()
{
    WriteMessage();
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

Console.WriteLine(float1/float2);
Console.WriteLine(number1/number2);
}
*/

/* Try-Catch challenge

using System.Diagnostics;

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}
Console.WriteLine("Exit Program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch
    {
        Console.WriteLine("Exception caught in Process1");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2); //infinite
    Console.WriteLine(number1 / number2);
}
*/

/* Catch specific exception types
Properties of the Exception class
    Data: The Data property holds arbitrary data in key-value pairs.
    HelpLink: The HelpLink property can be used to hold a URL (or URN) to a help file that provides extensive information about the cause of an exception.
    HResult: The HResult property can be used to access to a coded numerical value that's assigned to a specific exception.
    InnerException: The InnerException property can be used to create and preserve a series of exceptions during exception handling.
    Message: The Message property provides details about the cause of an exception.
    Source: The Source property can be used to access the name of the application or the object that causes the error.
    StackTrace: The StackTrace property contains a stack trace that can be used to determine where an error occurred.
    TargetSite: The TargetSite property can be used to get the method that throws the current exception.
*/

/*Exception catch checked
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occured");
}
Console.WriteLine("Exit Program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch(DivideByZeroException e) //Exception e
    {
        Console.WriteLine($"Exception caught in Process1: {e.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;
    try
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {e.Message}")
    }
    checked //catches overflowexceptions
    {
        try
        {
            smallNumber = (byte)number1;
        }
        catch (OverflowException e)
        {
            Console.WriteLine($"Exception caught in WriteMessage: {e.Message}");   
        }
    }
}
*/

/*Catch Seperate Exception types in a code block

/*
//InputValues is used to store numeric values entered by a user.
string[] inputValues = new string[] { "three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invlaid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you enntered is too large or too small");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
*/

/* Correct code using the try and catch 
checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
    }
}

try
{
    string str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null." + ex.Message);
}


try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range." + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}
Console.WriteLine("Exiting program.");
*/

/* How to create and throw exceptions in C# 
    Common Exception types that might be used when creating an exception.
    ArgumentException or ArgumentNullException: Use these exception types when a method or constructor is called with an invalid argument value or null reference.
    InvalidOperationException: Use this exception type when the operating conditions of a method don't support the successful completion of a particular method call.
    NotSupportedException: Use this exception type when an operation or feature is not supported.
    IOException: Use this exception type when an input/output operation fails.
    FormatException: Use this exception type when the format of a string or data is incorrect.

The Message property should explain the reason for the exception. However, information that's sensitive, or that represents a security concern shouldn't be put in the message text.

The StackTrace property is often used to track the origin of the exception. This string property contains the name of the methods on the current call stack, together with the file name and line number in each method that's associated with the exception. A StackTrace object is created automatically by the common language runtime (CLR) from the point of the throw statement. Exceptions must be thrown from the point where the stack trace should begin.

Creating an exception object: 
ArgumentException invalidArgumentException = new ArgumentException();
throw invalidArgumentException;
throw new FormatException("FormatException: Calculations in process XYZ have been cancelled due to invalid data format.");


string[][] userEnteredValues = new string[][]
{
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
};

foreach (string[] userEntries in userEnteredValues)
{
    try
    {
        BusinessProcess1(userEntries);
    }
    catch (Exception ex)
    {
        if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
        {
            Console.WriteLine(ex.Message);
        }
    }
}

static void BusinessProcess1(string[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            // completes required calculations based on userValue
            // ...
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
    }
}
*/

/* Rethrow exception
The BusinessProcess1 method has been updated to include additional details. BusinessProcess1 now encounters two issues and must generate exceptions for each issue.
The top-level statements have been updated. Top-level statements now call the OperatingProcedure1 method. OperatingProcedure1 calls BusinessProcess1 within a try code block.
The OperatingProcedure1 method is able to handle one of the exception types and partially handle the other. Once the partially handled exception is processed, OperatingProcedure1 must re-throw the original exception.


try
{
    OperatingProcedure1();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Exiting application.");
}

static void OperatingProcedure1()
{
    string[][] userEnteredValues = new string[][]
    {
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
    };

    foreach(string[] userEntries in userEnteredValues)
    {
        try
        {
            BusinessProcess1(userEntries);
        }
        catch (Exception ex)
        {
            if (ex.StackTrace.Contains("BusinessProcess1"))
            {
                if (ex is FormatException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Corrective action taken in OperatingProcedure1");
                }
                else if (ex is DivideByZeroException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                    // re-throw the original exception
                    throw;
                }
                else
                {
                    // create a new exception object that wraps the original exception
                    throw new ApplicationException("An error occurred - ", ex);
                }
            }
        }

    }
}

static void BusinessProcess1(string[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
        catch (DivideByZeroException)
        {
            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
            throw unexpectedDivideByZeroException;

        }
    }
}
*/

/*Prompt the user for the lower and upper bounds
Console.WriteLine("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;
bool exit = false;

do
{
    try
    {
        // Calculate the sum of the even numbers between the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the result to the user
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

        exit = true;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("An error has occurred.");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
        Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
        string? userResponse = Console.ReadLine();
        if (userResponse.ToLower().Contains("exit"))
        {
            exit = true;
        }
        else
        {
            exit = false;
            upperBound = int.Parse(userResponse);
        }
    }    
} while (exit == false);

//Wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    int sum = 0;
    int count = 0;
    decimal average = 0;

    if (lowerBound >= upperBound)
    {
        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lowerbound.");
    }
    int sum = 0;

    average = (decimal)sum / count;

    return average;
}
*/

string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};



try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    string operationStatusMessage = "good";
    string processStatusMessage = "";

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }
}

static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }
}