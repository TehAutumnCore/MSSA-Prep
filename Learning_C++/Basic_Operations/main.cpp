#include <iostream>



int main() {
    //Addition
    int number1{3};
    int number2{7};

    //Addition
    int result = number1 + number2; //10
    std::cout << "result : " << result << std::endl;
    
    //Subtraction
    result = number2 - number1;//4
    std::cout << "result : " << result << std::endl;
    
    //Division
    result = number2 / number1;//2
    std::cout << "result : " << result << std::endl;
    
    //Modulus
    result = number2 % number1;//1
    std::cout << "result : " << result << std::endl;
    
    //Multiplication
    result = number2 * number1;//21
    std::cout << "result : " << result << std::endl;

    return 0;
}