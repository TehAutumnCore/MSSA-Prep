# Add logic to C# console Applications(Get started with C#. Part 3)
# Evaluate Boolean Expressions to make decisions in C#
## Exercise - Evaluate an expression
C# Boolean Expressions: A Quick Reference
This document provides a quick reference for evaluating Boolean expressions, using comparison operators, and handling string comparisons in C#.

Core Concepts
Expression: Any piece of code that resolves to a single value. This can be a combination of values, variables, operators, and method calls.
Boolean Expression: A specific type of expression that evaluates to either true or false. These are the foundation of all decision logic in C#.
Comparison and Equality Operators
Equality Operator (==): Checks if two values are equal.

Returns true if they are the same; otherwise, false.
For example, 1 == 1 is true.

Inequality Operator (!=): Checks if two values are not equal.

Returns true if they are different; otherwise, false.
For example, "a" != "A" is true.

Numeric Comparison Operators: Used for comparing numeric types.

>: Greater than
<: Less than
>=: Greater than or equal to
<=: Less than or equal to
Effective String Comparison
String comparison requires special attention due to case sensitivity and whitespace.

Case-Sensitivity: Comparisons are case-sensitive by default.

Example: "apple" == "Apple" evaluates to false.

Whitespace: Leading or trailing spaces will cause comparisons to fail.

Example: " apple" == "apple" evaluates to false.

Best Practice for Reliable Comparison: To avoid these issues, you should "massage" the string data before comparing:

Use the .Trim() method to remove all leading and trailing whitespace.
Use .ToUpper() or .ToLower() to convert both strings to a consistent case.
By combining these, an expression like string1.Trim().ToLower() == string2.Trim().ToLower() provides a robust and reliable comparison.

Logical Negation & Boolean Methods
Boolean Methods: Some built-in methods return a bool value and can be used directly as a boolean expression.

Example: The myString.Contains("word") method returns true if the substring "word" is found within myString.

Logical Negation Operator (!): This operator, also known as the "not operator", inverts the result of a boolean expression.

It turns true into false and false into true.
For example, !myString.Contains("word") would be true only if myString does not contain "word".

Relationship between != and !: The inequality operator is essentially a shorthand for logical negation on an equality check.

The expression x != y is functionally identical to !(x == y).

## Implement the Conditional operator
The C# Conditional Operator (?:)
This guide explains the use of the C# conditional operator (?:), a compact tool for handling simple if-else logic that returns a value.

What is the Conditional Operator?
The conditional operator, ?:, is also known as the ternary conditional operator because it's the only operator in C# that takes three operands.
It works by evaluating a single Boolean expression and returning one of two values, depending on whether the expression is true or false.
It provides a concise, one-line alternative to a basic if-else statement.
Syntax
The basic structure is as follows:

<condition> ? <value_if_true> : <value_if_false>

<condition>: A Boolean expression that evaluates to true or false.
?: The operator token that follows the condition.
<value_if_true>: The value that is returned if the <condition> is true.
:: The operator token that separates the two possible return values.
<value_if_false>: The value that is returned if the <condition> is false.
Usage Examples
Assigning a Value: The most common use is to assign a value to a variable based on a condition.

For example, to set a discount based on a sale amount:
int discount = saleAmount > 1000 ? 100 : 50;
In this case, the discount variable will be assigned the value 100 if saleAmount is over 1000; otherwise, it will be assigned 50.

Using Inline: You can use the operator directly inside another expression or method call for even more compact code.

For example, you can print the discount directly without using a temporary variable:
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

# Code Blocks and Variable Scope
C# Code Blocks and Variable Scope
This document provides a reference for how code blocks ({}) work in C# and how they define the scope and lifetime of variables.

What are Code Blocks?
A code block is a group of one or more C# statements enclosed in curly braces ({}).
Code blocks are used to group statements together to define an execution path. They are fundamental to constructs like if statements, loops, and methods.
Understanding Variable Scope
Variable Scope refers to the visibility of a variable within your application's code.

A variable declared inside a code block has local scope.

This means the variable is only visible and accessible within that specific code block.

If you attempt to access a variable outside of the code block where it was declared, you will get a compiler error:

error CS0103: The name '...' does not exist in the current context

Making Variables Accessible Across Scopes
To make a variable visible and usable both inside and outside of a code block, you must declare the variable outside of (and above) the code block.
This places the variable in a higher-level scope, making it accessible to the lower-level (nested) code block.
The Importance of Initialization
Declaring a variable is not enough; the C# compiler must be able to prove that a variable has been initialized (assigned a value) before it is read.

The compiler analyzes all possible execution paths to ensure a variable is never read before it's assigned.

If you declare a variable outside a block but only assign it a value inside an if statement, the compiler will raise an error. This is because if the if condition is false, the code path would skip the assignment, leaving the variable uninitialized.

error CS0165: Use of unassigned local variable '...'

Best Practice: To avoid this, initialize variables with a default value when you declare them. This guarantees the variable always has a value, satisfying the compiler.

For example: int value = 0;

# Switch Statements
The C# switch Statement: A Guide
This document provides a reference for the switch statement in C#, a powerful selection construct for branching code flow based on a single value matching a list of possible patterns.

When to Use a switch Statement
The switch statement is an excellent alternative to a long if-elseif-else chain, especially when:

You are evaluating a single variable or expression (the "match expression").
You need to compare that value against a list of many known, discrete values.
The code to execute for any given match is relatively short and straightforward.
Syntax and Terminology
The basic structure of a switch statement is as follows:

switch (match_expression)
{
case value_1:
// Code to execute if match_expression == value_1
break;
case value_2:
// Code to execute if match_expression == value_2
break;
default:
// Code to execute if no other case matches
break;
}

match_expression: The variable or expression inside the parentheses () whose value will be tested.
case label: A single branch starting with the case keyword, followed by a value and a colon (e.g., case 100:).
switch section: The combination of a case label and the list of statements that execute when that label is matched.
Execution Flow and the break Keyword
The switch statement evaluates the case labels from top to bottom.
Once a case label matches the match_expression, the code within that switch section is executed.
In C#, execution is not allowed to "fall through" from one case section to the next.
The break keyword is required at the end of every switch section. It terminates the execution of the switch statement and transfers control to the code that follows it. Forgetting to include a break will result in a compiler error.
Handling Multiple Matches (Stacking Cases)
You can execute the same code for multiple case values by "stacking" their labels.

For example, if both employeeLevel 100 and 200 should receive the same title, you can write:

case 100:
case 200:
title = "Senior Associate";
break;

The default Case
The default keyword creates an optional switch section that will execute if and only if no other case labels match the match_expression.
Although it can be placed anywhere within the switch block, the default case is always evaluated last.
By convention, the default case is placed at the end of the switch block for logical clarity and readability.


# Create do and while iteration loops

C# Iteration: do-while and while Loops
This guide provides a reference for the do-while and while iteration statements in C#. These loops are ideal when the number of iterations is not known in advance and depends on conditions that can change within the loop's execution.

The do-while Statement
The do-while loop is defined by its core guarantee: the code block will always be executed at least once.

Execution Flow: The code block inside the do { ... } is executed first. Then, the Boolean expression in the while (condition) is evaluated at the end of the block. If the condition is true, the loop repeats.
Common Use Case: This loop is perfect for scenarios where an initial action must be performed before the condition can be tested. For example, getting user input or generating an initial random value that the loop's continuation depends on.
Syntax: do { /* code to execute */ } while (condition);
The while Statement
The while loop evaluates its condition before executing the code block, acting as a "gate" that controls entry into the loop.

Execution Flow: The Boolean expression in while (condition) is evaluated first. The code block only executes if the condition is true. After the block executes, the condition is checked again before the next iteration.
Execution Count: A while loop executes zero or more times. If the condition is false initially, the code block will never run.
Syntax: while (condition) { /* code to execute */ }
Controlling Loop Flow: The continue Statement
You can end the current iteration early and move directly to the next one using the continue keyword.

Function: The continue statement immediately stops processing the current iteration and transfers control back to the loop's condition check.

Behavior: It essentially says, "I'm done with this iteration, let's start the next one." Any code in the loop that comes after the continue statement is skipped for that specific iteration.

For example, you could use if (current >= 8) continue; to avoid processing or printing numbers that are 8 or greater, while still allowing the loop to continue running until its exit condition is met.

continue vs. break
It's crucial to understand the difference between these two keywords inside a loop:

continue: Skips the rest of the current iteration and proceeds to the next iteration of the loop.
break: Terminates the entire loop immediately. Execution transfers to the first statement that follows the loop block.

## Do vs While iteration statements

Challenge Guide: Applying do-while and while Loops
This document summarizes the key patterns and techniques for user input validation and data processing, as demonstrated in the challenge activity. The focus is on making the correct choice between a do-while and a while loop based on the problem's requirements.

Core Principle: Choosing the Right Loop
The fundamental difference to remember when choosing your loop is:

do-while: Use when the loop body must execute at least once. The condition is checked after the first run.
while: Use when the loop body might not need to execute at all. The condition is checked before each run, acting as a gate.
Pattern 1: Validating User Input with do-while
A do-while loop is the natural and most common choice for validating user input, because you always need to prompt the user and get their input at least once.

Validating Numeric Input
Safe Parsing with int.TryParse(): To prevent your application from crashing when a user enters non-numeric text (like "two"), use the int.TryParse() method. It is much safer than int.Parse().
How it Works:
It attempts to convert a string to an int.
It returns a bool: true if the conversion was successful, false otherwise.
It uses an out parameter to pass back the converted integer value.
Syntax: bool success = int.TryParse(userInputString, out int numericResult);

Validating String Input
Nullable Strings (string?): It's good practice to read user input into a nullable string? variable, as Console.ReadLine() can return null.
Normalizing Input: Before checking the user's string, always "normalize" it to accept a wider range of valid entries.
Use the .Trim() method to remove accidental leading or trailing spaces.
Use the .ToLower() (or .ToUpper()) method to perform case-insensitive comparisons.
Pattern 2: Processing Data Conditionally with while
When you need to repeatedly process parts of a larger data set (like sentences in a paragraph), a while loop is often a better fit. This is because you need to check if there is any data left to process before attempting to run the loop body.

The challenge of extracting sentences from a string demonstrates this pattern:

Check Condition First: Find the location of the first period (.).
Enter Loop: Start a while loop that continues as long as a period is found (while (periodLocation != -1)).
Process and Update: Inside the loop, extract the sentence, remove it from the original string, and then look for the next period to update the loop condition. If no more periods are found, the loop terminates correctly.
Useful String Methods for Data Processing
The challenges utilize several powerful string methods:

.IndexOf(string): Returns the zero-based index of the first occurrence of a character or string. Returns -1 if not found.
.Substring(startIndex, length): Extracts a new string from the original, starting at a specific index for a certain length.
.Remove(startIndex): Removes all characters from a specified position to the end of the string.
.TrimStart(): Removes all leading whitespace characters from the current string.