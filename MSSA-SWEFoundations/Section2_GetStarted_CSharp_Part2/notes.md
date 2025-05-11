# MSSA Software Engineering Foundations: Foundational C# with Microsoft 
# Create and run simple C# console applications (GetStarted with C#, Part 2)
## Call methods from the .Net class library using C#
<!-- Creating a new application -->
At the Terminal command prompt, to create a new console application in a specified folder, type dotnet new console -o ./CsharpProjects/TestProject

NET Class Library – Summary Notes
The .NET Class Library is a large collection of reusable classes and methods provided by Microsoft.

It supports many types of applications: console, web, desktop, mobile, cloud, and database.

Key Concepts:
Classes group related methods (e.g., System.Console contains WriteLine(), ReadLine(), etc.).

Simplifies programming by providing prebuilt functionality.

Data types like string and int are also classes in the library, with useful built-in methods (e.g., ToUpper(), Length).

Finding What You Need:
Use Microsoft’s official documentation.

Search online using blogs, forums, and examples.

Practice through projects to get familiar with commonly used classes and methods.

Takeaways:
You only need to learn the parts relevant to your project.

Developers rely on documentation and community resources to explore and understand the library.

## Call the methods of a .NET Class
Basic Method Call Structure
Syntax: ClassName.MethodName(arguments);
Example: Console.WriteLine("Hello World");
Method call requires:
Class name
Dot operator .
Method name
Parentheses () with optional arguments
VS Code Setup
Open VS Code → File > Open Folder → choose location
Trust folder if prompted
Open terminal: Terminal > New Terminal
Create a Console App

dotnet new console -o ./CsharpProjects/TestProject
Creates folders: CsharpProjects, TestProject
Files created: Program.cs, TestProject.csproj
Clear Program.cs for exercises
Method Call Example

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
Random.Next(1, 7) returns 1–6
Console.WriteLine(roll) <!--prints result Outputs a number between 1–6-->

Stateless vs Stateful Methods
Stateless: Always produces same result for same inputs (e.g., Math.Abs(-5))
Stateful: Output depends on internal object state (e.g., Random.Next())

## Return values and parameters of methods
Return Values

Methods can either return a value or not (void methods).
Return values communicate results back to the caller.
Example: int roll = dice.Next(1, 7);
Return value can be used directly: Console.WriteLine(dice.Next(1, 7));
Ignoring a return value (e.g., dice.Next(1, 7);) is possible but usually not useful.
Method Parameters & Arguments
Arguments are values passed when calling a method.
Parameters are variables defined in the method signature.

Example:

Random dice = new Random();  
int roll = dice.Next(1, 7);  
Console.WriteLine(roll);
Next(int, int) uses two int parameters for boundaries.

Type checking ensures correct argument types at compile time.
Not all methods require parameters (e.g., Console.Clear()).
Overloaded Methods
Same method name with different signatures (parameter type/number).
Console.WriteLine() has many overloads (e.g., int, string, none).
Random.Next() overloads:


int roll1 = dice.Next();         // 0 to int.MaxValue  
int roll2 = dice.Next(101);      // 0 to 100  
int roll3 = dice.Next(50, 101);  // 50 to 100  
Using IntelliSense in Visual Studio Code
IntelliSense shows suggestions, method signatures, and type info.
Triggered while typing (e.g., typing d, i, c shows dice).
Useful for exploring method overloads and autocompleting code.

Summary
Methods may return values or be void.
Parameters define expected input; arguments provide values.
Overloads support flexibility in method usage.
IntelliSense aids learning and productivity in code.

## discover and implement a method call challenge activity

int firstValue = 500;
int secondValue = 600;
int largerValue; 
<!-- find a method from the Math class that would return the largest number between the firstValue and the secondValue. -->
Console.WriteLine(Math.Max(firstValue,secondValue));
<!-- 
could have also done 
largerValue = Math.Max(firstValue,secondValue);
Console.WriteLine(largerValue);
 -->