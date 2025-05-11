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

 ## Create Decision Logic with if statements
 if Statements in C#
Used to control program flow based on conditions.
Executes a block of code only if a Boolean expression evaluates to true.
Commonly used with comparison and logical operators.
Dice Game Logic
Three dice are rolled, each returning a value between 1 and 6.
The total score is the sum of the three dice.
Bonuses are applied:
Two matching dice add a small bonus.
Three matching dice add a larger bonus.
If the final score meets or exceeds a threshold, the player wins.
Key Techniques
Use of conditional statements to apply game rules.
Boolean logic to detect matching dice.
Decision-making based on calculated outcomes.
 Other simple Boolean expressions can be created by using operators to compare two values. Operators include:

==, the "equals" operator, to test for equality
>, the "greater than" operator, to test that the value on the left is greater than the value on the right
<, the "less than" operator, to test that the value on the left is less than the value on the right
>=, the "greater than or equal to" operator
<=, the "less than or equal to" operator

C# Game with Decision Logic (If Statements)
Overview
This project demonstrates the use of decision logic in C# using if, else, and else if statements. The primary goal is to implement a game that simulates rolling three six-sided dice, calculating the score, and determining the outcome based on defined rules.

Features
Dice Rolling: The game generates three random dice rolls using Random.Next() and calculates the total.
Winning/Losing Logic: If the total score from the dice rolls is greater than or equal to 15, the player wins. Otherwise, they lose.
Bonus Points:
Doubles: If any two dice show the same value, the player gets a 2-point bonus.
Triples: If all three dice show the same value, the player receives a 6-point bonus.
Game Rules
Objective: Roll three dice, sum the values, and apply any bonuses (doubles or triples).
Win Condition: A score of 15 or more results in a win.
Loss Condition: A score less than 15 results in a loss.
Bonus:
Rolling two dice of the same value (doubles) adds 2 points.
Rolling all three dice of the same value (triples) adds 6 points.
Getting Started
Setup: Create a C# console application using Visual Studio Code.
Code Logic:
Use System.Random to simulate the dice rolls.
Use if statements to evaluate the total score and check for bonus conditions like doubles and triples.
Code Breakdown
Random Dice Rolls: Random dice = new Random();
Calculating Total: int total = roll1 + roll2 + roll3;
Decision Making:
Use if to determine if the player wins or loses based on the total score.
Check for doubles using if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)).
Check for triples with if ((roll1 == roll2) && (roll2 == roll3)).

## Creating nested decision logic with if, else if, and else
Purpose
This module covers control flow using conditional statements in C#, focusing on writing expressive logic using if, else, else if, and nesting. The goal is to improve code clarity, reduce redundancy, and handle mutually exclusive conditions correctly.

Definitions
if: Executes a code block if a Boolean condition is true.
else: Executes a code block if the preceding if condition is false.
else if: Tests a new condition if the previous if or else if condition is false.
nested if: An if or else block placed inside another if block to handle dependent logic.
Boolean expression: A condition that evaluates to true or false.

Core Concepts

Use if + else Instead of Two if Statements
When conditions are logical opposites (e.g., total >= 15 and total < 15), replace two if statements with if followed by else to simplify logic and avoid redundant comparisons.

Avoid Stacking Bonuses by Nesting Conditions
To prevent both doubles and triples bonuses from applying simultaneously, use a nested if inside an outer if. Check for triples first inside the doubles condition. This ensures mutually exclusive bonus logic.

Testing Logic with Hardcoded Values
Temporarily assign values to roll variables (e.g., roll1 = 6; roll2 = 6; roll3 = 5) to test specific outcomes. This avoids repeated random executions and ensures predictable testing.

Replace Binary Win/Lose with Multi-Prize Logic
Convert a simple win/lose game to a prize system:

total >= 16: win a car
total >= 10: win a laptop
total == 7: win a trip

otherwise: win a kitten
Use if, else if, else to ensure only one prize is awarded per run.

Decision Chain Principles
Use if + else when only two mutually exclusive outcomes exist.
Use if + multiple else if + else when multiple exclusive outcomes exist.
Only the first true condition's block is executed in an if–else if–else chain.
else is optional but must be the last block if used.
Nested if statements allow for tiered logic evaluation when one condition depends on another.

Best Practices
Simplify logic by avoiding repeated conditions.
Use nesting only when necessary for dependent logic.
Use else if chains to express exclusive paths clearly.
Use descriptive messages and test each path with controlled input for clarity and reliability.

##