# Statements and Functions

A statement is a basic unit of computation in a C++ program.
Every C++ program is a collection of statements organized in a certain way to achieve some goal.
Statements end with a semicolon in C++(;)
## Notes
```Cpp
#include <iostream>

int main(int argc, char **argv) 
{
    int firstNumber = 12;
    int secondNumber = 9;

    int sum = firstNumber + secondNumber;

    std::cout << "The sum of the two numbers is : " << sum << std::endl;

    return 0
}

// function
//return type function name parameters {  body  }
int addNumbers(int first_number, int second_number) {
    //variable sum takes first_number + second_number
    int sum = first_number + second_number;
    //returns variable
    return sum;
}
```
Statements are executed in order from top to bottom when the program is run.
Execution keeps going until there is a statement causing the program to terminate, or run another sequence of statements.
A function must be defined before it's use


-------------------------------------------------------------------------
## Best practice for using C++(C++20 and supported compiler)
```Cpp
#include <format>
#include <iostream>

int main() 
{
    int firstNumber = 12;
    int secondNumber = 9;

    int sum = firstNumber + secondNumber;

    std::cout << std::format("The sum of the two numbers is: {}\n",sum);

    return 0
}
```
-------------------------------------------------------------------------
## Legacy Code or C++17 and below
```Cpp
#include <iostream>

int main() 
{
    int firstNumber = 12;
    int secondNumber = 9;

    int sum = firstNumber + secondNumber;

    std::cout << "The sum of the two numbers is: " << sum << std::endl;

    return 0
}
```

-------------------------------------------------------------------------
## Somewhat completed program
```Cpp
int addNumbers(int first_number, int second_number) {
    int sum = first_number + second_number;
    return sum;
}

int main(int argc, char **argv) {
    int firstNumber = 12;
    int secondNumber = 9;

    int sum = firstNumber + secondNumber;
    //function passing variables
    sum = addNumbers(firstNumber, secondNumber);
    //function passing numbers directly
    sum = addNumbers(34,7);

    //Traditional output using std::cout and stream insertion
    std::cout << "The sum of the two numbers is : " << sum << std::endl;
    std::cout << "The sum of the two numbers is : " << addNumbers(23,8) << std::endl;

    //Modern output using std::format(C++20)
    std::cout << std::format("The sum of the two numbers: {}\n", sum);
    std::cout << std::format("The sum of the two numbers: {}\n", addNumbers(23,8));

    return 0;
}

```