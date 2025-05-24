# Variables and Data Types
Int main(){}: Entry point of the program, wher the program starts executing, with int meaning the function will return an integer to the OS while using 0 as success

Entry Point:The function where execution begins.

Statements: Individual instructions that the program executes.

Functions:Blocks of code, that perform a specific task and can be reused.

Error: A problem that stops the program from compiling or running

Warnings: Potential issues, but the program still compiles and runs

Input: Data the program receives, often from the keyboard

Output: Data the program displays

Comments: Ignored by the compiler = used to explain code

Dev Workflow: Steps a developer follows while writing and testing code.
    Write Code
    Compile(g++ main.cpp -o program)
    fix errors
    run and test
    repeat and improve

Memory Model: Describes how data is stored and accessed in memory. 
    Stack: For local variables and function calls
    Heap: For dynamically allocated memory(new,delete)
    Static/Global: Global variables
    code segment: The actual program instructions

Execution Model: How the program runs step by step
    start at main()
    execute statements top to bottom
    call functions as needed
    return from main() (often with return 0;)

----------------------------------------------------------------------------------------------------
```cpp
Data Types:
    int: Stores whole numbers (positive or negative) --4 bytes
        int age = 25l
    double:stores floating-point numbers with double precision (more decimal places than float) --8 bytes
        double pi = 3.14159265359;
    float:Stores floating-point numbers with single precision --4 bytes
        float temperature = 98.6f; //the 'f' ensures its treated as a float
    char:Stores a single character, uses single quotes, and is internally stored as an integer(ASCII value)
        char grade = 'A';
    bool: Stores true or false, and is internally stored as a 1(true) or 0(false)
        bool isPassed = true;
    void: means no type, used when a function does not return anything.
        void greet(){
            std::cout < "Hello!">;
        }
    
    auto:Automatically deduces the data type based on the value assigned, used to avoid redundancy.
        auto x = 42; //int
        auto y = 3.14;//double
        auto name = "Tom"; //const char
    
    ...: Used in variadic functions - functions that take a variable number of arguments. Usually used with C-style or low-level APIs
        void printValues(int count, ...); //Declaration with variable arguments.
```
----------------------------------------------------------------------------------------------------
Number Systems:

Binary
Octal
Hexadecimal