# Creating and Using Methods in C#
This guide provides a reference for the fundamentals of creating and using methods in C#. Methods are reusable blocks of code that perform a specific task, helping to organize and simplify your programs.

Anatomy of a C# Method
A method consists of two primary parts: its signature and its body.

1. The Method Signature
The signature is the method's declaration. It defines the method's name, the type of data it returns, and the parameters it accepts.

Syntax: <return type> <MethodName>(<parameter_list>)

Return Type: The data type of the value the method sends back after it completes. If the method does not return any data, the return type is void. A method can return any data type, such as int, bool, or even an array.
Method Name: The name you use to call the method.
Parameters: The list of input variables the method accepts, located inside the parentheses (). A method can have zero or more parameters of any data type.
2. The Method Body
The method body contains the actual code that will be executed when the method is called. The code is enclosed in curly braces {}.

Example:
void SayHello()
{
Console.WriteLine("Hello World!");
}

Calling a Method
You execute a method by "calling" (or "invoking") it.

To call a method, you use its name followed by parentheses: SayHello();
Arguments: When you call a method that accepts parameters, the values you provide are called arguments. For Console.WriteLine("Input!"), the string "Input!" is the argument passed to the WriteLine method.
Order of Definition: In C#, you can call a method before it is defined in your code file. It is a common convention to place method definitions at the end of a program file.
Understanding Execution Flow
When a method is called, the program's flow of execution changes temporarily.

The program runs sequentially until it reaches a method call.
Execution control transfers from the caller to the code inside the called method.
The method's code runs from start to finish.
Once the method is complete, execution control returns to the caller, and the program continues from the line immediately following the method call.
Best Practices for Naming
Clear and descriptive names are crucial for writing readable code.

Method Names:
Should be concise and clearly describe the task the method performs.
Should be written in PascalCase (e.g., DisplayDate, PrintArray).
Parameter Names:
Should accurately describe the information the parameter represents.
For example, (string month, int day, int year) is much clearer than (string a, int b, int c).

#Of course. Here is a summary of the provided text on creating C# methods that return values, formatted in the README.md style.

C# Methods that Return Values
This guide provides a reference for creating methods that perform operations and then return a resulting value to the code that called them.

Defining a Method with a Return Type
To create a method that returns a value, you specify the data type in the method signature, right before the method's name.

Return Type: Can be any data type, such as int, string, bool, or even an array. This is different from void, which specifies that the method returns nothing.
Compiler Rule: A method with a non-void return type must use the return keyword to send back a value of that exact type. The compiler will produce an error if there is any possible code path through the method that doesn't end with a return statement.
Example Signature:
double GetDiscountedPrice(int itemIndex)

The return Keyword
The return keyword is used to exit the method and send a value back to the caller. It is very flexible and can be used with different kinds of values.

What Can You Return? The return keyword can be followed by:

A variable: return result;
A literal value: return 50.0;
An expression: The expression is evaluated first, and its result is returned. This allows for more concise code.
return items[itemIndex] * (1 - discounts[itemIndex]);

The result of another method call:
return input.ToString().Substring(0, 5);

return in void methods: You can also use return; (without a value) in a void method to terminate its execution early.

Capturing and Using Return Values
The real power of returning methods is that the calling code can "capture" the returned value and use it immediately. This makes code more modular, organized, and readable.

A returned value can be used in many ways:

Assign it to a variable:
double finalPrice = GetDiscountedPrice(i);

Use it directly in a mathematical operation:
total += GetDiscountedPrice(i);

Use it as the condition for an if statement or ternary operator:
if (TotalMeetsMinimum()) { ... }

Pass it as an argument to another method:
Console.WriteLine($"Total: ${FormatDecimal(total)}");