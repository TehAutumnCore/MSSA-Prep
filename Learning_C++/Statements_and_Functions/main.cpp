#include <format>
#include <optional>
#include <stdexcept> // for std::invalid_argument
#include <iostream>


int addNumbers(int first_number, int second_number) {
    int sum = first_number + second_number;
    return sum;
}

int multiplyNumbers(int first_number, int second_number) {
    int product = first_number * second_number;
    return product;
}

int subtractNumbers(int first_number, int second_number) {
    int difference = first_number - second_number;
    return difference;
}

int divideNumbers(int first_number, int second_number) {
    if (second_number == 0) {
        throw std::invalid_argument("Division by zero");
    }
    return first_number / second_number;

}

/*
//optional is a wrapper that may or may not contain a value of type (T)
//Its useful when a function might not be able to return a meaningful value for every input, but dont want to throw exceptions. 
//optional instead of exception? Avoids overhead of exceptions if the case is common and expected(such as division by zero, and how its normal for the function to run gracefully)
// The caller has to check explicitly if a value is present before using it, which encourages safer code.

std::optional<int> divideNumbers(int first_number, int second_number) { 
    if (second_number == 0) {
        return std::nullopt;
    }
    return first_number / second_number;
}

int divide(int first_number, int second_number) {
    return second_number == 0 ? throw std::invalid_argument("Division by zero") : first_number / second_number;
}

*/

int main() {
    int first_number{13};
    int second_number{7};
    int sum = first_number + second_number;
    // int sum = addNumbers(first_number,second_number);

    std::cout << "---Legacy---" << std::endl;
    std::cout << "First number : " << first_number << std::endl;
    std::cout << "Second number : " << second_number << std::endl;
    std::cout << "Sum : " << sum << std::endl; //20
    std::cout << "Sum : " << addNumbers(2,4) << std::endl; //6
    
    
    std::cout << std::endl;
    std::cout << '\n';

    // sum = addNumbers(25,7); //32
    // sum = addNumbers(30,54); //84

    std::cout << "---Modernized---" << std::endl;
    std::cout << std::format("First number: {}\n Second number: {}\n",first_number,second_number);
    std::cout << std::format("Sum: {}\n",sum);//20
    std::cout << std::format("Sum: {}\n",addNumbers(2,4));//6 

    try {
        std::cout << "10 / 2 = " << divideNumbers(10,2) << "\n";
        std::cout << "10 / 0 = " << divideNumbers(10,0) << "\n";
    } catch (const std::invalid_argument& exception) { //const means the exception object cannot be modified in the catch block
        std::cerr << "Caught exception: " << exception.what() << "\n"; //standard character error 
    } 
    // Catch exception by const reference and '&' to avoid copying and prevent modification. Will also preserve actual type of exception when dealing with inheritance

    try {
        std::cout << std::format("10 / 2 = {}\n", divideNumbers(10,2));
        std::cout << std::format("10 / 0 = {}\n", divideNumbers(10,0));
    } catch (const std::invalid_argument& e) { // & means we catch by reference to avoid copying the exception object(more efficient)
        std::cerr << std::format("Caught Exception: {}\n",e.what());
    } 
    return 0;
}