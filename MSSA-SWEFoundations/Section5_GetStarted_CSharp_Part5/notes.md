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

#