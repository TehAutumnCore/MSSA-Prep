# MSSA Software Engineering Foundations: Foundational C# with Microsoft 
# Introduction - What is C# is used for?
    business applications to capture, analyze, and process data
    Dynamic web applications that can be accessed from a web browser
    Games, both 2D and 3D
    Financial and scientific applications
    Cloud-based applications
    Mobile Applications

C# is case-sensitive language
common errors could include:
    Entering lower-case letters instead of capitalizing C in Console, or the letters W or L in WriteLine
    Entering a comma instead of a period between Console and WriteLine
    Forgetting to use double-quotation marks, or using single-quotation marks to surround the phrase Hello World!
    Forgetting a semi-colon at the end of the command

comment using //

Compilation: a special program called a compiler converts your source code into a different format that the computers central processing unit can execute. When code is run using the green Run button, the code written was first compiled then executed.Compilers bridges communication between humans and computers by translating human-readable instructions into a computer-understandable set of instructions.

Syntax: rules for running code, like human languages with punctuation and sentence structure. They define the keywords and operators of C# and how they put together to form programs. The subtle changes of color to different words and symbols is Syntax highlighting. This is a feature that helps spot mistakes in the code. 

Console.WriteLine("Hello World!");
When a phrase is surrounded by double quotation marks in c# code its referred to as a literal string. In other words, you LITERALLY want the characters 'H','e','l','l','o' and so on sent to the output.

The Console part is called a class. Classes "own" methods, such as methods live inside of a class. followed by invoking the method by using parentheses after the methods name, lastly followed by the method invocation operator.
Console.WriteLine -> class.method("Method Invocation Operator"); <-semi colon is the end of statement operator

Difference between Console.WriteLine and Console.Write is Console.WriteLine appends a new line after the output.

## Store and retrieve data using literal and variable values in C# - Introduction
This module focuses on working with data in C# using hard-coded values, known as constants or literal values. It emphasizes the importance of displaying formatted messages that combine hard-coded strings with user-collected information. Participants will learn to create literal values for five basic data types, declare and initialize variables, retrieve and set values in variables, and allow the compiler to determine data types during initialization.

Key Learning Objectives:
Create literal values for various data types.
Declare and initialize variables.
Retrieve and set variable values.
Understand how the compiler infers data types.
Prerequisites:
Basic understanding of C# syntax.
Familiarity with Console.WriteLine().
Beginner-level experience with a .NET editor.
Code Examples:
C#

// Example of creating a literal value
string successMessage = "Operation succeeded!";

// Example of declaring and initializing a variable
int userAge = 25;

// Example of retrieving and setting values
Console.WriteLine(successMessage);
userAge = 30;
Console.WriteLine(userAge);

## Exercise: Declare Variables

// A literal is a hard-coded value — one that doesn't change as the program runs.
// But most real-world applications need to handle values from users, files, or networks.
// To work with such dynamic data, you use variables.


// What is a variable?

// A variable is a container that holds a value of a specific data type.
// Variable values can change (or *vary*) during the execution of a program.

// - You can assign a value to a variable.
// - You can read the value stored in a variable.
// - You can change the value later.

// A variable name is a human-readable label that refers to a memory location.
// To use or update the stored value, you reference the variable name.


// Declare a variable

// To declare a variable, specify its data type followed by its name:
string firstName;

// This creates a string variable named firstName.
// From now on, firstName can only hold string values.


// Variable name rules and conventions

// Syntax rules:
// - Names can contain letters, digits, and underscores (_)
// - Names must start with a letter or underscore, not a digit
// - Names are case-sensitive (e.g., value vs Value)
// - Names must not be C# keywords (e.g., string string; is invalid)


// Naming conventions:
// - Use *camelCase* — start with a lowercase letter, capitalize each new word
//   Example: string thisIsCamelCase;
// - Begin names with a letter (avoid underscores unless needed for special cases)
// - Make names descriptive — represent the value they store
// - Use full words (avoid abbreviations or contractions)
// - Don’t include the data type in the name (e.g., not string strName;)


// Valid variable declaration examples:
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;


// Recap

// - Variables are temporary values stored in memory
// - Before using a variable, you must declare it
// - Declaration = [data type] + [name]
// - Variable names must follow specific rules and naming conventions

// Now that you can declare variables, next you'll learn how to set, retrieve, and initialize their values.


## Exercise: Setting and Getting Values from Variables

 Goals
 - Declare, assign, retrieve, and reassign values to variables in C#
 - Understand assignment rules and type enforcement

 Key Concepts

 Declare a variable
string firstName;

 Assign a value (Set operation)
firstName = "Bob";

 Retrieve a value (Get operation)
Console.WriteLine(firstName); // Outputs: Bob

 Common Errors

 Incorrect assignment order
"Bob" = firstName;
 Error CS0131: The left-hand side of an assignment must be a variable, property or indexer

 Type mismatch
int firstName;
firstName = "Bob";
 Error CS0029: Cannot implicitly convert type 'string' to 'int'

 Unassigned variable usage
string firstName;
Console.WriteLine(firstName);
// Error CS0165: Use of unassigned local variable 'firstName'

 Reassigning Values

string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

firstName = "Liem";
Console.WriteLine(firstName);

firstName = "Isabella";
Console.WriteLine(firstName);

firstName = "Yasmin";
Console.WriteLine(firstName);

 Output:
 Bob
 Liem
 Isabella
 Yasmi
 Initialization Best Practice

// Initialize at the time of declaration
string firstName = "

## Exercise: Declare Impplicity typed local variables

 An implicitly typed local variable is declared using the `var` keyword followed by an initialization.

 Example:
var message = "Hello world!";

 In this case, the variable `message` is assigned a string value.
 The compiler infers the type from the value, so `message` becomes a string.

 After type inference, the variable behaves just like a regular typed variable.
 The `var` keyword is useful for long or obvious data types.


// Example with type inference:
var message = "Hello world!";
 The compiler treats `message` as a string.
 Therefore, trying to assign a value of another type will cause an error.


 Invalid example:
var message = "Hello World!";
message = 10.703m;

 Output:
 error CS0029: Cannot implicitly convert type 'decimal' to 'string'


 Note:
 In other programming languages, `var` might work differently.
 In C#, whether you use `var` or the actual type, the variable’s type is fixed at declaration.


 Variables using `var` must be initialized.
 This means you can't write:

var message;

 Output:
 error CS0818: Implicitly-typed variables must be initialized


 Why use `var`?

 - Saves keystrokes when the type is obvious
 - Makes code cleaner when dealing with complex types
 - Useful during early development when exact type is undecided

 Tip:
 As a beginner, it's helpful to stick with explicit type declarations
 until you're more comfortable reading and writing C# code.


 Recap

 - `var` tells the compiler to infer the variable's type from its initial value
 - Once inferred, the type is fixed and cannot be changed
 - `var` is commonly used in modern C# code
 - Use explicit types early on to better understand your variables

## Exercise - Combine Strings using character escape sequences

Escape Sequences like:

\n for new lines

\t for tabs

\" for double quotes

\\ for backslashes

\r for carriage return

Verbatim Strings (@) to avoid escape characters and preserve line breaks and backslashes (great for file paths).

Unicode (\uXXXX) to display characters from other languages, like Japanese (e.g., "こんにちは").
----------------------------------------------------------------------------------
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");
Console.Write(@"c:\invoices");

//Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World");

//To generate Japanese invoices:
// Nihon no seikyu-sho o seisei suru ni wa
Console.Write("\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
//User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

-------------------------------------------------------------------------------------
Generating invoices for customer "Contoso Corp" ... 

Invoice: 1021		Complete!
Invoice: 1022		Complete!

Output Directory:	
c:\invoices    c:\source\repos
        (this is where your code goes)
c:\invoicesこんにちは World

日本の請求書を生成するには：
	c:\invoices\app.exe -j


## Exercise - Combine strings using string concatenation
String concatenation is the process of combining two or more strings using the `+` operator. It's commonly used to build messages or combine variable values with literal strings.

You can concatenate a literal string with a variable to form a new message, such as adding a user's name to a greeting. Multiple variables and literal strings can be combined in a single expression.

Intermediate variables can be used to hold the resulting string, but they are optional. If they don't improve readability, it's better to perform the concatenation directly where it's needed.

Key takeaways:
- Use `+` to combine strings.
- Concatenate variables and literal strings in one line when possible.
- Avoid unnecessary intermediate variables for cleaner code.

## Exercise - string interpolation
String interpolation allows you to embed variables directly within a string template by prefixing the string with a `$` symbol and using curly braces `{}` for expressions.

It improves readability and conciseness compared to string concatenation, especially when combining multiple variables and literal strings.

Interpolation can be used directly in `Console.WriteLine` or assigned to variables, and it eliminates the need for temporary variables when not necessary.

You can also combine interpolation with verbatim string literals by prefixing the string with `$@` to support both embedded variables and file paths or other strings requiring backslashes.

Key takeaways:
- Use `$"..."` to embed expressions within strings.
- Interpolation is more readable and concise than concatenation.
- Combine `$` with `@` as `$@"..."` for verbatim interpolated strings.


# Perform Basic operations on numbers in C#
## Exercise - Perform addition with implicit data conversion
The `+` operator in C# is overloaded and used for both numeric addition and string concatenation, depending on the types of operands.

When both operands are numbers (e.g., ints), `+` performs mathematical addition.

When combining strings and numbers, the compiler implicitly converts numbers to strings if it detects string concatenation is intended.

Mixing strings and numbers without parentheses can lead to unexpected results due to left-to-right evaluation and type coercion.

Parentheses can be used to explicitly define the intended order of operations, ensuring numeric addition happens before string concatenation.

It's best to avoid mixing calculation and concatenation in a single line to maintain clarity and prevent misinterpretation by the compiler.

## Exercise = Perform math operations
## C# Math Operations Overview

This document serves as a concise reference for performing mathematical operations in C#, handling data types correctly, and ensuring accurate calculations.

Basic Arithmetic Operators

C# provides standard arithmetic operators for basic math:

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);         // Output: 12
Console.WriteLine("Difference: " + difference); // Output: 2
Console.WriteLine("Product: " + product); // Output: 35
Console.WriteLine("Quotient: " + quotient); // Output: 1

C# Math Operations Overview

This document outlines how to work with basic math operations in C#, including how the language handles data types like int and decimal, how to cast between types, use the modulus operator, and respect the correct order of operations.

Basic Arithmetic Operators
C# provides several standard arithmetic operators:
+ for addition
- for subtraction
* for multiplication
/ for division

When performing division using integers (int), the result is also an integer, and any decimal part is discarded (truncated). For example, 7 / 5 results in 1, not 1.4.

Decimal Division
To get an accurate decimal result from division, at least one of the numbers must be a decimal, and the result must also be stored in a decimal variable. In C#, decimal literals use the m suffix (e.g., 7.0m). For example, 7.0m / 5 correctly yields 1.4.

This is important because dividing two integers will always result in an integer unless explicitly converted. Using a floating point or decimal type ensures that fractional digits are preserved.

Type Casting
If you have two integer variables and want a precise result with decimal places, you must cast one or both values to a decimal using the cast operator. This is done by placing the target type in parentheses before the variable, like (decimal)first. This tells the compiler to temporarily treat the value as a different data type.

For example, casting both first and second as decimal before dividing them ensures the result includes any fractional value rather than being truncated.

Modulus Operator
The % operator is used to determine the remainder after division. For example, 7 % 5 returns 2, since 5 goes into 7 once, with 2 left over. When the result of a modulus operation is 0, it means the first number is divisible by the second. This operator is especially useful for tasks like checking every Nth element in a loop or validating even divisibility.

Order of Operations
C# respects standard mathematical order of operations, often remembered by the acronym PEMDAS:
Parentheses
Exponents (note: C# does not have a dedicated exponent operator; use System.Math.Pow)
Multiplication and Division (left to right)
Addition and Subtraction (left to right)
To force operations to occur in a particular order, parentheses should be used. For instance, 3 + 4 * 5 evaluates as 3 + (4 * 5) = 23, while (3 + 4) * 5 evaluates as 7 * 5 = 35.

Summary
C# supports standard arithmetic operators (+, -, *, /)
Integer division truncates decimal values; use decimal for precise results.
To preserve decimals, either use literal decimal numbers or cast integer values to decimal.
Use the modulus operator (%) to find remainders and check divisibility.
C# follows PEMDAS for operation order; parentheses can override default precedence.
Type casting is done using parentheses and allows temporary conversion of a value to a different type.
This foundational knowledge is essential for performing reliable numeric operations in C# applications.


## Exercise - Increment and decrement values 
Increment and Decrement Values
Increment and Decrement
Frequently, you'll need to increment and/or decrement values, especially when you're writing looping logic or code that interacts with a data structure.
The += operator adds and assigns the value on the right of the operator to the value on the left of the operator.
The ++ operator increments the value of the variable by 1.
The -- operator decrements the value of the variable by 1.
These same techniques can be used for subtraction, multiplication, and more.

Compound Assignment Operators

Operators like +=, -=, *=, ++, and -- are known as compound assignment operators because they compound some operation in addition to assigning the result to the variable. The += operator is specifically termed the addition assignment operator.

Example:

You can use these operators to increment and decrement a value as follows:
Increment by adding 1 using value = value + 1; or value += 1; or value++;
Decrement by subtracting 1 using value = value - 1; or value -= 1; or value--;
Position the Increment and Decrement Operators
Both the increment and decrement operators have an interesting quality: depending on their position, they perform their operation before or after they retrieve their value.
If you use the operator before the value, as in ++value, the increment happens before the value is retrieved.
If the operator comes after the value, as in value++, the increment happens after the value is retrieved.

Important Notes:
The order of operations matters. When the operator comes before the value (++value), the operation happens before the value is used. When it comes after (value++), the value is used first, and then the operation is applied afterward.

Recap
Use compound assignment operators like +=, -=, *=, ++, and -- to perform a mathematical operation like increment or decrement, then assign the result into the original variable.
Increment and decrement operators perform differently depending on whether the operator is before or after the operand.

## Complete the challenge to convert Fahrenheit to Celsius
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m) ;
Console.WriteLine($"{celsius:F2}");

# Guided Project - Calculate and Print Student Grades
<!-- My work below: -->
<!-- int currentAssignments = 5; -->

```csharp
Dictionary<string, int[]> students = new Dictionary<string, int[]>{
    {"Sophia", new int[] {93,87,98,95,100} },
    {"Nicolas", new int[] {80,83,82,88,85} },
    {"Zahirah", new int[] {84,96,73,85,79} },
    {"Jeong", new int[] {90,92,98,100,97} }
};

Console.WriteLine("Student          Grade");
foreach (var (student, grades) in students) {
    double gpa = grades.Sum() / (double)grades.length                         //(double)currentAssignments; -->
    char grade = gpa switch {
        >=90 => 'A',
        >=80 => 'B',
        >=70 => 'C',
        >=60 => 'D',
    _=>'F'
    };
Console.WriteLine($"{student,-12}   {gpa,6}  {grade}");
}
```

# Guided Project
You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:

You're given the student's name and class information.
Each class has a name, the student's grade, and the number of credit hours for that class.
Your application needs to perform basic math operations to calculate the GPA for the given student.
Your application needs to output/display the student’s name, class information, and GPA.
To calculate the GPA:

Multiply the grade value for a course by the number of credit hours for that course.
Do this for each course, then add these results together.
Divide the resulting sum by the total number of credit hours.
```csharp
Dictionary<string, (int grade, int creditHours)> sophiaCourses = new() {
    {"English 101", (4,3) },
    {"Algebra 101", (3,3) },
    {"Biology 101", (3,4) },
    {"Computer Science I", (3,4) },
    {"Psychology 101", (4,3) }
};

string studentName = "Sophia Johnson";
double totalGradePoints = 0;
double totalCreditHours = 0;

Console.WriteLine($"Student: {studentName}");
Console.WriteLine("");
Console.WriteLine($"{"Course",-20}{"Grade",5}\t{"Credit Hours"}");
foreach(var(courseName, (grade, creditHours)) in sophiaCourses) {
   double gpa = grade * (double)creditHours;
   totalGradePoints += gpa;
   totalCreditHours += creditHours;
Console.WriteLine($"{courseName,-20}{grade,5}\t{creditHours,5}");
};
double GPA = totalGradePoints / totalCreditHours;
Console.WriteLine("");
Console.WriteLine($"Final GPA: \t\t\t\t{GPA:F2}");
```